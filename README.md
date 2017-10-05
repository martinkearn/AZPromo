
# Azure Pass Manager
Azure promotional pass codes can be used to evaluate and use Azure services. The codes are often distributed at hackathons and similar events.

This repository contains a web application and associated back-end services used to manage the distribution of Azure trial pass codes. 

This solution will not help you get the codes, there is an existing process for that which is avaliable to Microsoft employees.

You can use the site that is built via this repository at https://aka.ms/azurepassmanager (built on the master branch)

## Project History and Credits
This repository is built with thanks and gratitude on the work of a small team within the CSE group at Microsoft who worked on a similar project at an internal hackathon in September 2017. The internal project was not open source but much of the code and architecture in this project was taken (with permission) from the hackathon output, the team was
* [Dariusz Porowski](https://twitter.com/DariuszPorowski)
* [Denis Cepun](https://twitter.com/DenisCepun)
* [Francesca Longoni](https://www.linkedin.com/in/francesca-longoni-wehq/)
* [Christine Matheney](https://twitter.com/Matheneyc)
* [Sudhir Rawat](https://twitter.com/rawatsudhir)
* [Martin Kearn](https://twitter.com/MartinKearn)

## Issues, feedback, feature requests etc
Please use the [GitHub issues](https://github.com/martinkearn/Azure-pass-manager/issues) section to log all feedback.

## Usage - Administrators (the people with the codes)
If you work for Microsoft and handle Azure trial codes, this section is for you.

### Getting started, just the basics
Follow these steps to get up and running
1. Order codes at https://requests.microsoftazurepass.com. If you request is approved, you'll receive your codes as a CSV file and you'll be told what the expiration date is.
1. Go to https://aka.ms/azurepassmanager and sign in with your corporate credentials
1. Go to `Upload Codes` and set a name for your event (make it simple and easy to remember), expiration date for the codes (you'll have been told this in the email that contained your CSV) and upload the CSV
1. Your event is live and codes are available to use. You can view/manage your events at `Your Events`. View your event to see the URL you should direct users to in order to claim their code
1. (optional) You may want to use http://aka.ms to setup a short URL for your event; your call.

### After your event
When your event is completed, you may want to see data about how many codes were claimed, to do this
1. Go to https://aka.ms/azurepassmanager and sign in with your corporate credentials
1. You can view/manage your events at `Your Events`
1. You can view data about used/un-used codes and export them as a CSV

If you want to clear your event you can optionally export unused codes (they might be useful at a future event?) and then simply `Delete event and codes` to remove your event and all codes from the system.

## Contact me
Contact Martin.Kearn@Microsoft.com with comments and feedback that you don't want to log as a [GitHub issue](https://github.com/martinkearn/Azure-pass-manager/issues).