C:\Users\skjal\OneDrive\Dokumenter\GitHub\java-getting-started>heroku pg:psql                                            »   Warning: heroku update available from 7.53.0 to 7.62.0.                                                            --> Connecting to postgresql-spherical-91355                                                                            psql: error: connection to server at "ec2-3-223-242-224.compute-1.amazonaws.com" (3.223.242.224), port 5432 failed: Connection timed out (0x0000274C/10060)                                                                                             Is the server running on that host and accepting TCP/IP connections?                                             !    psql exited with code 2
(probably due to firewall settings at hvl)

'java' is not recognized as an internal or external command operable program or batch file.
(had to add java to PATH)


heroku run java -version
Error: connect ETIMEDOUT 3.94.73.63:5000
(probs firewall again)