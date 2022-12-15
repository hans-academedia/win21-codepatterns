using _01_DRY.Interfaces.Handlers;
using _01_DRY.Interfaces.Helpers;
using _01_DRY.Interfaces.Models;

namespace _01_DRY.Helpers;

internal class SMSSender : ISMSSender
{
    private readonly ISMS sms;
    private readonly ILogger log;
    private readonly IProject project;

    public SMSSender(IProject project, ISMS sms, ILogger log)
    {
        this.project = project;
        this.sms = sms;
        this.log = log;
    }

    public async Task SendSMSAsync()
    {
        var smsResonse = await sms.SendAsync(project.ProjectOwner.PhoneNumber, $"New project named {project.ProjectName} was created successfully.");
        if (smsResonse != null)
            log.LogInformation($"A SMS was sent to {project.ProjectOwner.PhoneNumber}.");
    }
}
