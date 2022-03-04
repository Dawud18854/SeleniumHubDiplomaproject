###Loadtesting my Diplomaproject through Selenium using SeleniumHub

(In Absprache mit Herr Prof. Hassanen, statt Gatling zu nutzen, nutze ich Selenium + SeleniumGrid) 

Start the project by
1. Opening a shell in the folder
    - write "docker-compose up" to start the docker container for seleniumGrid,
    -  access the Hub on localhost:4444
    
2. Now start the Berechtigungsmanagement software 
    - either on localhost:44365 
    - or access it through the public url (currently not accessable)
    
3. Last but not least run the tests in any IDE for C#
    - if you test locally then run 'LocalLoadTests'
    - else run 'ServerLoadTests'
