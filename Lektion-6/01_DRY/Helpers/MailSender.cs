using _01_DRY.Interfaces.Handlers;
using _01_DRY.Interfaces.Helpers;
using _01_DRY.Interfaces.Models;

namespace _01_DRY.Helpers;

internal class MailSender : IMailSender
{
    private readonly IMailer _mailer;
    private readonly ILogger _log;
    private IProject _project;

    public MailSender(IMailer mailer, ILogger log)
    {
        _mailer = mailer;
        _log = log;
    }

    public void Configure(IProject project)
    {
        _project = project;
    }

    public async Task SendMailAsync()
    {
        var mailResponse = await _mailer.SendAsync(_project.ProjectOwner.Email, "New project was created successfully", $"Project {_project.ProjectName} ({_project.ProjectNumber}) was created successfully with you as the project owner.");
        if (!string.IsNullOrEmpty(mailResponse))
            _log.LogInformation($"An e-mail was sent to {project.ProjectOwner.Email}.");
    }
}
