# FunctionsClassLibrary
Example of a .funproj along with a Web App project for Azure Functions 

Use the web project for building and deploying, and the Functions project for running locally with debugging. 

Idea courtesy of [@SimonLuckenuik](https://github.com/SimonLuckenuik).

## Project setup steps 

Here are steps on how to produce the project layout in this sample:

1.	Create an ASP.NET Web Application project. Copy any existing Functions code by downloading from Kudu and convert from .csx to .cs files.
2.  (Optional) Copy existing App Settings from a Function App using the Azure Functions CLI:
    ```
    func azure login
    func azure functionapp list
    func azure fetch-app-settings <name>
    ``` 
3.	Add a new Function Project to the solution. This will create a new folder for the Function Project.
4.	Remove the new Function Project from the solution and navigate to it in Windows explorer. 
5.	Copy the files projectname.funproj and host.json to your Web App project folder.
6.	Add the function project to your Visual Studio solution.
7.  Add a manual project dependency between the two projects: right-click on the Function project and navigate to **Build Dependencies** -> **Project Dependencies...**.

    ![](https://cloud.githubusercontent.com/assets/4260261/23920891/b17847ac-08b9-11e7-9db6-698eca7c52c7.png)

    ![](https://cloud.githubusercontent.com/assets/4260261/23920713/02c5270c-08b9-11e7-87f2-ed7f368b4bf0.png)

## Running and publishing

The Functions project automatically includes files from the project directory and since it is the same directory as the Web Project, it will include any binaries. 

Use the Functions project to run and publish, and the Web project to do the actual build.