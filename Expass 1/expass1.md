# Installation: Software Development Environment
Java, IntelliJ (my IDE of choice for java), and git was already installed on my computer and thus i could skip these steps of installation. Installing maven was a pretty straightforward process, as editing PATH variable is something i have done multiple times before. Overall no issues with installation.
I also have had this github account for years. 

I validated the install both by running various test commands, such as <br>`mvn --version`<br>`java --version`<br>`git --version`<br> as well as testing previous programs I have made where I used these technologies to see that it all actually works. 

# Experiment: Heroku and Platform as a Service
Having already used Heroku to host a Discord bot created in javascript/typescript I was familiar with the process, and it was pretty similar for Java. I created a new Heroku account, as the free ones only allow for one active cluster at a time.

Following the step by step instructions worked fine for the most part, installing postgres was a straightforward process, having used Heroku previously i was also familiar with the CLI.

For the sake of simplicity I used the provided sample app as opposed to creating a new one from scratch. 

I have also used maven previously so the dependency system as well as the build commands were familiar to me. 

Deploying the app worked flawlessly. 

I skipped the Provision Add-ons step, as the github repo for the task specified that you had to register with payment info for this, which I have already linked with another Heroku account.

Using the database caused the first of my few issues, the following error popped up instead of the intended database interface:

```powershell
C:\Users\skjal\OneDrive\Dokumenter\GitHub\java-getting-started>heroku pg:psql                                                --> Connecting to postgresql-spherical-91355                                                                            psql: error: connection to server at "ec2-3-223-242-224.compute-1.amazonaws.com" (3.223.242.224), port 5432 failed: Connection timed out (0x0000274C/10060)                                                                                             Is the server running on that host and accepting TCP/IP connections?                                             !    psql exited with code 2
```
My initial theory was that this was related to firewall settings while at HVL, which turned out to be the case as I could connect just fine when I tried at UiB as well as at home.

The rest of the step by step guide worked fine until the section of starting a one-off dyno, where the following error occurred:
```powershell
heroku run java -version
Error: connect ETIMEDOUT 3.94.73.63:5000
```
which effectively was the same issue as the one I encountered when attempting to connect to the database, a firewall setting on the HVL version of Eduroam. This command also ran fine at UiB and at home.

# Link to Heroku App

The link to the deployed heroku sample application is: <br> https://calm-spire-25805.herokuapp.com/ 
<br> (I let it randomly select a name for the app because I was curious what it would create)


## Final note:
Just in case the random name on this GitHub account causes any confusion, this repo does in fact belong to Skjalg Eide Hodneland, I'd rather not create another GitHub account so I'm using my personal GitHub. If this is an issue, please let me know and I will change to using a GitHub with my name as the username.