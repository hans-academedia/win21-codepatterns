using _01_DRY.Factories;
using _01_DRY.Handlers;
using _01_DRY.Helpers;
using _01_DRY.Interfaces.Handlers;
using _01_DRY.Interfaces.Helpers;
using _01_DRY.Interfaces.Models;
using _01_DRY.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Twilio.TwiML.Voice;

ILogger log = GenericFactory.Create<Logger>();
IMailer mailer = MailerFactory.Create("", "", 587, "", "");
ISMS sms = SMSFactory.Create("", "", "");

IProjectOwner projectOwner = ProjectOwnerFactory.CreateProjectOwner("Hans", "Mattin-Lassei", "hans.mattin-lassei@epndata.com", "073-986 89 30");
IConsultant consultant = ConsultantFactory.CreateConsultant("Joakim", "Wahlström", "joakim.wahlstrom@epndata.com", "073-986 89 30");

IProject project = ProjectFactory.Create("The Awesome Project", projectOwner);
log.LogInformation($"Project {project.ProjectName} ({project.ProjectNumber}) was created successfully.");

IMailSender mailSender = MailSenderFactory.Create(project, mailer, log);
mailSender.SendMailAsync().ConfigureAwait(false);

ISMSSender smsSender = SMSSenderFactory.Create(project, sms, log);
smsSender.SendSMSAsync().ConfigureAwait(false);


Console.WriteLine("kör vidare i applikationen.");

Console.ReadKey();

