using System;
using System.Collections.Generic;
using System.Text;
using QUIZ.core.Models;

namespace QUIZ.core
{

    public static class Questions
    {

//  εδω δημιουργούμε τις ερωτήσεις για το ΠΕΡΙΒΑΛΛΟΝ (τις βάζουμε μέσα στη λίστα χρησιμοποιόντας μια κλάση)

       public static List<QuizQuestion> NatureQuestions = new List<QuizQuestion>()
            {
                new QuizQuestion("Which day is Earth Day?","December 21 ","August 12 "," April 22 "),

                new QuizQuestion("Name the atmospheric layer closest to the ground","Mesosphere","Thermosphere","Troposphere"),

                new QuizQuestion("The most abundant gas on the earth’s atmosphere is","Carbon","Hydrogen","Nitrogen"),

                new QuizQuestion(" What atmospheric layer has most of the clouds?","Mesosphere","Thermosphere","Troposphere"),

                new QuizQuestion("The study of weather is called?","climatology","aeronomy","meteorology"),

                new QuizQuestion("Which one of the following is NOT a primary layer of the atmosphere?","Stratosphere","Troposphere","Exosphere"),

                new QuizQuestion("Name the atmospheric layer that is completely cloudless and free of water vapor.","Stratosphere","Troposphere","Thermosphere"),

                new QuizQuestion("Which of the following is an amphibian?"," Lizards","Fish","Salamanders"),

                new QuizQuestion("What is the safe level of noise intensity for humans?","Up to 90 decibels","up to 70 decibels","up to 80 decibels"),

                new QuizQuestion("The region of air close to the earth and extending up to 10km high is called","Atmosphere"," Stratosphere","Troposphere"),

                new QuizQuestion("What are planktons?"," Plants living in water","Very small animals living on land","Very small plants and animals living in water"),

                new QuizQuestion("The production of light by living beings is known as","Bio-lighting","Bio-fluorescence","Bio-luminescence"),

                new QuizQuestion("Which country is popularly knowns as ‘land of the windmills’?","Norway","Poland","The Netherlands"),

                new QuizQuestion("Who was the first man to travel in space?","Neil Armstrong","Edwin Aldrin","Yuri Gagarin"),

                new QuizQuestion("Which instrument is used to measure wind velocity?","Barometer","Hygrometer","Anemometer"),

                new QuizQuestion("What is the instrument used to detect earthquakes?","Radiometer","Barometer","Seismograph"),

                new QuizQuestion("What is the unit in which radio activity is measured?","Newton","Decibel","Roentgen"),

                new QuizQuestion("The region of the atmosphere above 400 km and higher is known as","Mesosphere","Thermosphere","Exosphere"),

                new QuizQuestion("The major diet of pandas is","Acacia leave","Grass","Bamboo"),

                new QuizQuestion("Which of the following is not an endangered animal?","Siberian tiger","Loggerhead turtle","The Maned Wolf"),

                new QuizQuestion("Agrostology is the study of","Agriculture","Algae","Grasses"),

                new QuizQuestion("What does an anemologist study?","Animals","Atoms","Wind"),

                new QuizQuestion("Name the largest freshwater lake in Northeast India","Gurudongmar Lake","Lake Tsongmo","Loktak Lake"),

                new QuizQuestion("Do you know the only floating park in the world, located in North East India?","Kanchendzonga National Park","Dibru-Saikhowa National Park","Keibul Lamjao National Park"),

                new QuizQuestion("Which camel species has two humps on its back?","Arabian camel","dromedary camels","Bactrian camel"),

                new QuizQuestion("By 2040, the world's population is expected to rise to approximately","12 billion","20 billion","9 billion"),

                new QuizQuestion("Which is the longest mountain range in the world?","Karakoram","Himalayas","Andes"),

                new QuizQuestion("The natural process of the atmosphere heating through the trapping of re-radiated infrared radiation is known as","Thermal inversion","Global warming","The green house effect"),

                new QuizQuestion("In what type of bioregion is desertification is most likely to occur?","Coniferous Forests","Tropical Forests","Grasslands"),

                new QuizQuestion("PVC is a very toxic form of plastic. What is the full form of PVC?","Polyvinyl camphor","Polymer vinyl chloride","Polyvinyl chloride"),

                new QuizQuestion("Which of the following materials can be recovered from the recycling of soft drink cans?","Plastic","Paper","Metal"),

                new QuizQuestion("What are arboreal animals?","Animals living in water and land","Animals living in water","Animals living in trees"),

                new QuizQuestion("What are terricolous animals?","Animals that live in a particular region","Animals that live on high mountains","Animals that live in the soil"),



            };


        //  εδω δημιουργούμε τις ερωτήσεις για την ΤΕΧΝΟΛΟΓΙΑ (τις βάζουμε μέσα στη λίστα χρησιμοποιόντας μια κλάση)

        public static List<QuizQuestion> TechnologyQuestions = new List<QuizQuestion>()
        {
            new QuizQuestion("About how many computer languages are in use?","500","5,000","2,000"),

            new QuizQuestion("Which of these is not an early computer?","SAGE","UNIVAC","NASA"),

            new QuizQuestion("Who founded Apple Computer?","Bill Gates","Sundar Pichai","Steve Jobs"),

            new QuizQuestion("Which of these is not a peripheral, in computer terms?","keyboard","monitor","motherboard"),

            new QuizQuestion("Which of these is not one of the early “protocols,” or ways to use the Internet?","Gopher","Telnet","blogging"),

            new QuizQuestion("What does the Internet prefix WWW stand for? ","Worldwide Weather","Wide Width Wickets","World Wide Web"),

            new QuizQuestion("A network designed to allow communication within an organization is called:","the Internet","a browser","an intranet"),

            new QuizQuestion("Which of these is not a kind of computer?","Lenovo","Apple","Lada"),

            new QuizQuestion("What device, released in 1993, gave rise to the term personal digital assistant?","iPhone","Microsoft Surface","Newton MessagePad"),

            new QuizQuestion("What is the name for a computer pointing device?","a sound card","a modem","a mouse"),

            new QuizQuestion("What operating system did Google develop?","iOS","Windows","Android"),

            new QuizQuestion("What does the acronym FTP stand for?","fast total processing","file tripling power","file transfer protocol"),

            new QuizQuestion("Computer trojans are an example of:","spyware","network security devices","malware"),

            new QuizQuestion("What was the name of the chess-playing computer that made history when it defeated world champion Garry Kasparov in 1996?","Rybka","Chiptest","Deep Blue"),

            new QuizQuestion("Which of these was the first programmable general-purpose electronic digital computer?","BINAC","Acorn Network Computer","ENIAC"),

            new QuizQuestion("Who coined the term 'artificial intelligence'?","Donald Ervin Knuth","Charles Bachman","John McCarthy"),

            new QuizQuestion("Which company released its first notebook computer, the 316LT, in 1989?","Hewlett-Packard","Apple","Dell"),

            new QuizQuestion("Which of these was the first supercomputer?","Sierra","Cray-1","CDC 6600"),

            new QuizQuestion("Which of these was the first personal computer?","Apple I","Osborne 1","Altair"),

            new QuizQuestion("Which of these was the first cell phone to use the Android operating system?","Samsung Rant","BlackBerry Storm","T-Mobile G1"),

            new QuizQuestion("Which of these education-oriented computer languages was developed by Niklaus Wirth?","Logo","BASIC","Pascal"),

            new QuizQuestion("Who created the computer-programming language FORTRAN?","John McCarthy","Bill Atkinson","John Backus"),

            new QuizQuestion("Who was the first recipient of the A.M. Turing Award?","John McCarthy","Marvin Minsky","Alan Jay Perlis"),

            new QuizQuestion("Which of these was the first large-scale electronic computer?","Cray-1","Osborne 1","Colossus"),

            new QuizQuestion("Which of these was the world's first business computer?","HP-85","IBM 1401","LEO"),

            new QuizQuestion("In what year was Google founded?","1989","2001","1998"),

            new QuizQuestion("Who invented the distributed network as well as data packet switching across distributed networks?","Jean Bartik","Manuel Blum","Paul Baran"),

            new QuizQuestion("What device converts digital signals to analog signals?","central processing unit (CPU)","transistor","modem"),

            new QuizQuestion("What was the name of the controversial software surveillance system developed by the U.S. Federal Bureau of Investigation and used during investigations circa 2000–02?","ECHELON","Blue Iris","Carnivore"),

            new QuizQuestion("Who is known as the first computer programmer?","Alan Turing","Charles Babbage","Ada Lovelace"),

            new QuizQuestion("Which of these was the first microprocessor, developed in 1971?","Intel 8088","Intel Pentium","Intel 4004"),

            new QuizQuestion("What coding issue was projected to create havoc in computer networks around the world in 2000?","Storm Worm","CryptoLocker","Y2K bug"),

            new QuizQuestion("Who designed the high-speed computers known as supercomputers?","Larry Page","Alan Turing","Seymour R. Cray"),

            new QuizQuestion("Who is credited with inventing the term 'software engineer'?","Tommy Flowers","Evelyn Granville","Margaret Hamilton"),

            new QuizQuestion("What is the name of the digital file format that was devised in 1987 to reduce the size of images and short animations?","TIFF","PNG","GIF"),

            new QuizQuestion("What blogging site was founded by David Karp in 2007?","Lifehacker","Medium","Tumblr"),

            new QuizQuestion("What type of electromagnetic waves does Wi-Fi use?","infrared waves","gamma rays","radio waves"),

            new QuizQuestion("In the 1990s, this company created a computer programming language called Java:","Oracle Corporation","IBM","Sun Microsystems, Inc."),

            new QuizQuestion("A number that uniquely identifies each computer on the Internet is called:","Gopher","DNS","IP address"),

            new QuizQuestion("The computer programming language used for typesetting technical documents is called:","SQL","SGML","LaTeX"),

            new QuizQuestion("In what year was the first text message sent?","1995","1983","1992"),

            new QuizQuestion("When was Microsoft founded?","1986","1980","1975"),

            new QuizQuestion("What technology helps make telephone calls over the Internet possible?","Ethernet","Bluetooth","VoIP"),

            new QuizQuestion("Who created WikiLeaks?","David Karp","Bill Gates","Julian Assange"),

            new QuizQuestion("Which of these video game consoles was released in 1994?","Xbox","Atari 2600","PlayStation"),

            new QuizQuestion("Who is known for his patent for the computer mouse?","Gary Kildall","Reynold Johnson","Douglas Engelbart"),

            new QuizQuestion("What kind of computer is intermediate in size between a laptop and a smartphone and uses a keyboard, a stylus, or a touch screen to input information?","minicomputer","personal computer","tablet computer"),

            new QuizQuestion("What does the acronym EPROM stand for?","equipped programmable read-only machine","embedded proxy read-only messaging","erasable programmable read-only memory"),

            new QuizQuestion("What does the acronym DNS stand for?","domain number system","document name system","domain name system"),

            new QuizQuestion("What was the first interactive computer-graphics program?","Notepad","CorelDRAW","Sketchpad"),

            new QuizQuestion("When was Oracle Corporation founded?","2005","1995","1977"),

            new QuizQuestion("Which of these is not a computer language?","Hypertalk","Ada","Windows 2000"),





        };


    }
}
