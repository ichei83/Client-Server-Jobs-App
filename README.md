# Jobs-App

## Add your files

- [ ] [Create](https://docs.gitlab.com/ee/user/project/repository/web_editor.html#create-a-file) or [upload](https://docs.gitlab.com/ee/user/project/repository/web_editor.html#upload-a-file) files
- [ ] [Add files using the command line](https://docs.gitlab.com/ee/gitlab-basics/add-file.html#add-a-file-using-the-command-line) or push an existing Git repository with the following command:

```
cd existing_repo
git remote add origin https://github.com/ichei83/Client-Server-Jobs-App.git
git branch -M main
git push -uf origin main
```

## Name
Jobs Application.


## Description
Application which display active jobs and it's prediction
Also display jobs views per day

## Pre Installation

angular-pandologic-jobs
Install Node.js from: https://nodejs.org/en/download/
Install angular cli

PandoLogicWebServer
Required software: Visual Studio.


## Installation and Build Commands
angular-pandologic-jobs
Go to download folder ./angular-pandologic-jobs and open cmd window
run 'npm install' in target have all dependencies
npm run build # build to a directory
npm run start # continously build, as a server

PandoLogicWebServer
Required software: Visual Studio.

## Run Applications
There are 2 options to run the system:
 - Using localhost
 - Using Docker-compose

 Localhost Option:

 angular-pandologic-jobs:
  - Go to download folder ./angular-pandologic-jobs and open cmd window
  - run npm start or ng serve is angular cli is installed
  Client web application is up and listening on: http://localhost:4200/

PandoLogicWebServer:
 - Open PandoLogicWebServer solution using visual studio (considering project already have all relevant dependencies) just build and run   as PandoLogicWebServer application (development mode)
  PandoLogicWebServer Server web application is up and listening on: http://localhost:5000/
  * Using this link: http://localhost:5000/swagger/index.html will open Swashbuckle and will use for testing relevant api

## Usage
Use examples liberally, and show the expected output if you can. It's helpful to have inline the smallest example of usage that you can demonstrate, while providing links to more sophisticated examples if they are too long to reasonably include in the README.

## Support
For any issue, please contact: ichei83@gmail.com

