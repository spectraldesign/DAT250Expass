# Technical problems
The first major issue I encountered during this assingment was getting rid of the CORS error when attempting to connect to localhost:8080/todos in order to use the previously made API. Following the guide published in announcements I got past these errors, however I got another error where it now sent the request as localhost:8080/todos/api for some reason. In order to fix this I had to add `"pathRewrite": {"^/api" : ""}` to proxy.conf.json (thank you stackoverflow).
After fixing this issue I struggled a bit with getting the form to create a new Todo to work properly, but I got this sorted in the end.

# Link to code
The Angular code can be found in ./spa, here is the [direct link](). 
The code for Expass4, which was used for the API can be found [here]().

# Pending Issues
Getting a basic understanding of Angular and getting it to work with the Todo API took longer than expected so I did not have time to do the optional Experiment 3.
Occassionally it also seemed like the Todo table showed up empty when there was only a single Todo in the database, however this seemed to have fixed itself and I cannot currently reproduce this error, but be aware that this might happen if you test the code.