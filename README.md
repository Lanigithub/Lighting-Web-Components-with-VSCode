## LWC(Lightning Web Components) with VSCode:
### SFDX : Salesforce Developer Experience (‘SFDX’ or just ‘DX’) is a set of tools designed to improve the traditional developer’s experience of building on the platform. 
***
### LWC vs Aura Components: 
(https://developer.salesforce.com/docs/component-library/documentation/en/lwc/lwc.get_started_introduction)
#### you can build Lightning components using two programming models: Lightning Web Components, and the original model, Aura Components. Lightning web components are custom HTML elements built using HTML and modern JavaScript. Lightning web components and Aura components can coexist and interoperate on a page. To admins and end users, they both appear as Lightning components.
#### Choose LWC OR Aura? LWC is easier to is easier to use and it could operate on browsers. Always choose Lightning Web Components unless you need a feature that isn’t supported.
#### Compose Aura Components from Lightning Web Components: https://developer.salesforce.com/docs/component-library/documentation/en/lwc/lwc.interop_aura_composition
#### Create Lightning Web Components: (https://developer.salesforce.com/docs/component-library/documentation/en/lwc/lwc.create_components_introduction)
***
### SFDX in VSCodes Challenges:

***
### Challenge 1 : Quick Start: Lightning Web Components
https://trailhead.salesforce.com/en/content/learn/projects/quick-start-lightning-web-components?trail_id=force_com_dev_intermediate&trailmix_creator_id=lanfu2&trailmix_slug=lanis-trailmix

### Project 1: Set Up Your Salesforce DX Environment: 
https://trailhead.salesforce.com/en/content/learn/projects/quick-start-lightning-web-components/set-up-salesforce-dx?trail_id=force_com_dev_intermediate&trailmix_creator_id=lanfu2&trailmix_slug=lanis-trailmix

#### Learning Objectives
#### In this project, you’ll:

#### Install Salesforce CLI.
#### Create and deploy a Lightning web component.
#### Create and deploy a Lightning web component.
***
### Project 2: Set Up Visual Studio Code
(https://trailhead.salesforce.com/en/content/learn/projects/quick-start-lightning-web-components/set-up-visual-studio-code?trail_id=force_com_dev_intermediate&trailmix_creator_id=lanfu2&trailmix_slug=lanis-trailmix)

***
### Project 3: Create a Hello World Lightning Web Component
( https://trailhead.salesforce.com/en/content/learn/projects/quick-start-lightning-web-components/create-a-hello-world-lightning-web-component?trail_id=force_com_dev_intermediate&trailmix_creator_id=lanfu2&trailmix_slug=lanis-trailmix)
#### Steps:
#### 1. Create a Salesforce DX Project
Now that you’ve set up your development environment, you can create a simple Lightning web component.

In Visual Studio Code, open the Command Palette by pressing Ctrl+Shift+P (Windows) or Cmd+Shift+P (macOS).
Type SFDX.
Select SFDX: Create Project.
Press Enter to accept the standard option.
Enter HelloWorldLightningWebComponent as the project name.
Press Enter.
Select a folder to store the project.

#### 2. Authorize Your Trailhead Playground
In Visual Studio Code, open the Command Palette by pressing Ctrl+Shift+P (Windows) or Cmd+Shift+P (macOS).
Type SFDX.
Select SFDX: Authorize an Org.
Press Enter to accept the Project Default login URL option.
Press Enter to accept the default alias.
This opens the Salesforce login in a separate browser window.
Log in using your Trailhead Playground credentials.
If prompted to allow access, click Allow


#### 3. Create a Lightning Web Component
In Visual Studio Code, open the Command Palette by pressing Ctrl+Shift+P (Windows) or Cmd+Shift+P (macOS).
Type SFDX.
Select SFDX: Create Lightning Web Component. Don't use SFDX: Create Lightning Component. (This creates an Aura component.)
Enter helloWorld for the name of the new component.
Press Enter to accept the default force-app/main/default/lwc.
Press Enter.
View the newly created files in Visual Studio Code
#### 4. Deploy to Your Trailhead Playground
Right-click the default folder under force-app/main
Click SFDX: Deploy Source to Org.
In the Output tab of the integrated terminal, view the results of your deployment. If the command ran successfully, a Deployed Source message lists the three files that were uploaded to the org.
#### 5. Add Component to App in Lightning Experience
In Visual Studio Code, open the Command Palette by pressing Ctrl+Shift+P (Windows) or Cmd+Shift+P (macOS).
Type SFDX.
Select SFDX: Open Default Org.
This opens your Trailhead Playground in a separate browser.
From the App Launcher (App Launcher), find and select Sales.
Click Setup gear then select Edit Page.
Drag the helloWorld Lightning web component from the Custom area of the Lightning Components list to the top of the Page Canvas. 





