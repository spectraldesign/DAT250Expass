# Technical problems
I had to reconfigure JAVA_HOME to get `./mvnw spring-boot:run` and `./mvnw clean package`  to run properly, in the start I got an error stating something along the lines of "Please set the JAVA_HOME variable in your environment to match the location of your Java installation.". This was quickly resolved by changing the JAVA_HOME as well as the PATH environment variables.
Using the Spring Initializr to generate files for the examples caused an issue when running the aformentioned commands where it was "Unable to find a single main class from the following candidates: [list of candidates]". To resolve this issue I had to point to a main class by adding `<start-class\>com.example.package.File</start-class\>` to pom.xml, where package and File would be the file i wanted to run.

# Code
The code is in the same directory as this .md file ([here]()). Since the demo instructions wanted the same setup for the first 3 tutorials in terms of Spring Initializr setup I combined them in one project. I made a separate one for Experiment 4 since it required different dependencies.

# Pending issues
None