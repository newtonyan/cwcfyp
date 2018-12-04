using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Story : MonoBehaviour {

    [SerializeField] private TextMeshProUGUI storyText;

    public TextMeshProUGUI StoryText
    {
        get { return storyText; }
    }

    public void setText(int ID)
    {
        storyText.text = StoryContent(ID);
    }

    public string StoryContent(int ID)
    {
        //CC 
        if (ID == 1)
        {
            return "Chung Chi College was founded by the representatives of the Protestant Churches in Hong Kong in 1951." +
                "In the first year, there were only 63 students.Lessons were conducted in the Cathedral Hall and St.Paul's Co-educational College on Hong Kong Island. " +
                "In 1956, the campus was moved to Ma Liu Shui and was incorporated into the Chinese University of Hong Kong in 1963 as one of the three constituent institutions." +
                " The motto of the college is \"keep going until perfection is achieved\", which is quoted from the Great Learning," +
                " a classic Confucian literature.\n\nFully residential and dining included: \nNo\n\nAssembly: \n4 times per semester\n\n" +
                "Final year project: \nrequired\n\nCollege general education requirement: \n(2+1) credits, excluding FYP";
        }
        //NA 
        else if (ID == 2)
        {
            return "New Asia College was founded by Mr Ch'ien Mu and other scholars from mainland China in 1949." +
                "The vision of the college was to combine the educational essence of the Song and Ming academics and the tutorial system of western institutions.Humanism is the foundation of the college." +
                "The college also endeavours to facilitate communications between the west and the east.It was incorporated into the Chinese University of Hong Kong in 1963." +
                "The motto of the college is (candidness and acumen), which is quoted from the Doctrine of the Mean, a Confucian philosophy title.\n\n" +
                "Fully residential and dining included: \nNo\n\nAssembly / high table lunch/ dinner: \n3 assemblies or 2 assemblies + 1 student lunch/ dinner colloquium or 2 assemblies + 1 public lecture \n\n" +
                "Final year project: \nNot required\n\nCollege general education requirement: \n(3+3) units";
        }
        //UC 
        else if (ID == 3)
        {
            return "United College was founded in 1956 as an admixture of the Canton Overseas, Kwang Hsia, Wah Kiu, Wen Hua, and Ping Jing College of Accountancy. It was incorporated into the Chinese University of Hong Kong in 1963. Whole-person education is a vital theme in the college. The college holds the Distinguished Visiting Scholar Lectures, Annual Workshop and College Assemblies every year to broaden students' horizon, which prepares them to contribute to the society, country and humanity in general. The motto of the college is \"making one's virtues gleam and enlighten the people\", which is quoted from the Great Learning, a classic Confucian literature.\n\nFully residential and dining included: \nNo\n\nAssembly: \n3 assemblies per semester\n\nFinal year project: \nRequired\n\nCollege general education requirement: \n(2+1) units, excluding FYP";
        }

        //Shaw
        else if (ID == 4)
        {
            return "Shaw College was founded in 1986 as the fourth constituent college of the Chinese University of Hong Kong. The patron was Sir Run Run Shaw, who donated substantially towards the formation of the college. The college was located in the northern part of the campus. The College Sign (a grey sculpture located at the college entrance, often called the \"lady's leg\" by students) is the most iconic structure of the campus. It symbolizes the college's determination and steadfast resolution to face new challenges. The motto of the college is \"cultivating one's virtue and teach\", which is quoted from The Analects of Confucius, one of the most highly regarded Confucian title.\n\nFully residential and dining included: \nNo\n\nAssembly: \n3 times per semester\n\nFinal year project: \nNot required\n\nCollege general education requirement: \n(3+3) units";
        }


        ///MC
        else if (ID == 5)
        {
            return "Morningside College was founded in 2006 with the donation from the Morningside Foundation. Morningside College is one of the three colleges in the Chinese University of Hong Kong that is fully residential and provides communal dining. With one-third mainland students, one-third international students and one-third local students, Morningside College is the most diverse college in the university. The motto of the college is \"to be erudite, to be virtuous and to serve\".\n\nFully residential and dining included: \nYes\n\nHigh-table dinners: \n4 times per semester\n\nFinal year project: \nNot required\n\nCollege general education requirement: \n(3+3) units ";
        }
        //SHHo
        else if (ID == 6)
        {
            return "The S.H. Ho College was founded in 2006 with the donation from the S.H. Ho Foundation Limited. Morningside College is one of the three colleges in the Chinese University of Hong Kong that is operated on a fully residential and communal dining basis. A running theme of the college is the concept of \"home\". The college endeavours to provide students with a sense of home instead of a mere place to live and eat at. It is noteworthy that due to the nature of the founding organization, the college often has the highest ratio of medical students amongst all colleges in the Chinese University of Hong Kong. The motto of the college is \"culture, morals, devotion, trustworthiness\", which is quoted from the Analects of Confucius, one of the most highly regarded Confucian title.\n\nFully residential and dining included: \nYes\n\nHigh-table dinners: \n2~3 times per semester\n\nFinal year project: \nNot required\n\nCollege general education requirement: \n(3+3) credits";
        }

        //CWC
        else if (ID == 7)
        {
            return "The C.W. Chu College was founded in 2007 with private donations. The C.W. Chu College is one of the three colleges in the Chinese University of Hong Kong that is operated on a fully residential and communal dining basis. The vision of the college is to draw scholars from a diverse background and form a close community which endeavours to contribute the world with curiosity and generosity. Being one of the newest campuses in the university, the college facilities are in relatively better qualities than other facilities throughout the university. The college is located on the back side of the university campus, making it a somewhat isolated part in the university. The motto of the college is Cultus et Beneficentia (cultivating oneself and benefiting the community), making it the only college with a Latin motto in the university.\n\nFully residential and dining included: \nYes\n\nHigh-table dinners: \n2 times per semester\n\nFinal year project: \nRequired\n\nCollege general education requirement: \n3 credits, excluding FYP";
        }


        //WYS
        else if (ID == 8)
        {
            return "Wu Yee Sun College was founded in 2007 by the donation from the Wu Yee Sun Charitable Foundation Limited. The Creative Lab is the most iconic facility in the college. It is an intellectual playground for students to explore ideas form a multi-disciplinary perspective, express curiosity and combine entertainment and learning. Students are encouraged to come up with creative ideas and turn them into actual actions. The motto of the college is \"scholarship and endeavour\".\n\nFully residential and dining included: \nNo\n\nAssembly/high-table dinner: \n1 assembly + 1 high table dinner\n\nFinal year project: \nRequired\n\nCollege general education requirement: \n3 credits, excluding FYP";
        }

        //Woosing
        else if (ID == 9)
        {
            return "The Lee Woo Sing College was founded in 2007 with the support from the Li Foundation (Bing Hua Tang). The college aims at developing leaders with local and global perspectives. The college also emphasizes the spirit of 'Harmony'. The Chinese name of the college is, where translates to harmony, which is marked by kindness and moderation, making it an essential quality of being a leader. The motto of the college is wisdom, humanity, integrity and harmony, which is quoted from the Rites of Zhou, a ritual Confucian text.\n\nFully residential and dining included: \nNo\n\nAssembly/high-table dinner: \n1 assembly + 1 high table dinner\n\nFinal year project: \nRequired\n\nCollege general education requirement: \n3 credits, excluding FYP";
        }

        //Gate of Wisdom
        else if (ID == 10)
        {
            return "The Gate of Wisdom is a piece of artwork placed in front of the University Library of CUHK. It was designed by Taiwanese sculptor Ju Ming in 1986 and was later gifted to CUHK. Since then, it has become one of the most iconic structures of CUHK. The appearance of the Gate of Wisdom resembles two fighters battling each other, which is a metaphor for fierce academic debates between scholars. There is a legend associated with the Gate of Wisdom, stating that students passing through the gate from the direction of the library will graduate with first class honour, while passing from the other direction will result in the inability in graduating (others say that passing through the gate from either direction will result in graduation with a miserable honour). Several major students movements also happened in the Gate of Wisdom, such as supporting the democratic movement in China in 1989 (June 4th Massacre) and the public consultation of the 2003 National Security Bill (Basic Law Article 23).";
        }

        //Lake Ad Excellentiam
        else if (ID == 11)
        {
            return "Also named the Weiyuan Lake (the incomplete lake), the Lake Ad Excellentiam is located in the Chung Chi College. The name of the lake resembles incompleteness and implies the needs to search for perfection, which echoes the motto of the Chung Chi College: keep going until perfection is achieved. The path leading to the lake from the University station is called the philosophy path, which encourages people to think about philosophy when they are taking a walk around the bridge. The red, octagon pavillion located at the centre is called the Lion Pavillion. The pond located next to the Lake Ad Excellentiam is called Lake of the Cultivation of Virtue. It is also called Lake of the Cultivation of Ducks, which is a pun since the Cantonese pronunciation of \"virtue\" sounds like the English word \"duck\". The names of the two bridges on the lake carry philosophical meanings: the Crooked Bridge and the Arched Bridge resemble the roller-coaster experience of everyone's life. However, one can always overcome the obstacles and cross the to the other side.";
        }

        //Pavillion of Harmony
        else if (ID == 12)
        {
            return "The Pavillion of Harmony is located in the New Asia College. It is \"the second most scenic spot in Hong Kong\" as stated by the former Vice-Chancellor Prof. Ambrose King. It was built to commemorate Dr Ch'ien Mu, the founder of the college and the author of the \"Concept of the Union of Man and Nature\". The clear pond water blends harmoniously with the blue sky to form a natural and beautiful picture, which echoes with the notion of harmony with nature in Dr. Mu's title. The Pavillion of Harmony is also a hot spot for shooting graduation photos and wedding photos. Dr. Mu's \"Concept of the Union of Man and Nature\" and the \"Seal of Harmony \" engraved on the wall outside of the pavillion are the works of former Professor Yun Woon Lee and Professor Kam Tang Tong from the Art department. ";
        }

        //Amphitheatre
        else if (ID == 13)
        {
            return "The New Asia Amphitheatre is well known for the names of all the past graduates engraved behind the stage. When no activities are being held in the amphitheatre, it serves as a resting spot for students to take a walk or sit down and listen to music at the auditorium. Several students activities including the banquet of a thousand people and the night of congee. Several large events also took place at the amphitheatre, such as the I.CARE Film Festival in 2014 (featuring Adam Wong, the director of the movie The Way We Dance) and the University Lecture on Civility in 2017-18, which invited the essayist and cultural critic Yingtai Lung as a speaker.";
        }

        //Water Tower
        else if (ID == 14)
        {
            return "The New Asia Water Tower proudly stands at the highest point of the university campus. The 120-feet tower is visible from Tai Po Road and the Tolo Harbour Highway. The original purpose of the water tower was to store water for plumbing and drinking. However, thanks to the advancement in technology, the water tower is no longer used today and serves only as a landmark. The New Asia Tower, alongside the United College Tower, and jointly called the  \"Gentlemen Tower\" and the \"Lady Tower\" among students because of the roughness of the New Asia Tower and the elegance of the United College Tower. Enormous banners are sometimes hung on the tower wall during special occasions. For security measures, the tower is not open for students to enter. ";
        }

        //UGym
        else if (ID == 15)
        {
            return "The University Gymnasium is the core of all sports facilities in the university. There are courts for tennis, basketball, volleyball, handball and badminton. There is also a fitness room and a recreational room for table tennis activities. The Sir Philip Haddon-Cave Sports Field is also right next to the gymnasium. Most facilities are available for students to book online. ";
        }

        //CCGate
        else if (ID == 16)
        {
            return "Chung Chi Gate is located at one of the entrances of the university. The original gate was built in 1959, The pavillion named (Pavillion of Perfection) was also built near the gate. The words Chung Chi College were engraved in the front of the archway while the words keep going until perfection is achieved, which is the motto of Chung Chi College) were engraved at the back of the archway. These words echoed with the pavillion and highlighted the spirit of Chung Chi College in the pursuit of perfection. In 2001, the gate was demolished and reconstructed into a new structure that resembles the old gate in appearance except that it was taller. The original components of the archway were then put in the herbal garden and the Chung Chi Piazza in the forms of sculptures.";
        }

        //SciCen
        else if (ID == 17)
        {
            return "With the university emblem overlooking the University Mall, the science centre has become the most iconic landmark of the Chinese University of Hong Kong. Most of the departments within the Science Faculty are stationed at the Science Centre. The Science Centre is nicknamed (bottom of a pot) because its shape resembles the bottom of an electric pot. ";
        }

        //UCBall
        else if (ID == 18)
        {
            return "The Satellite Remote Sensing Receiving Station is a vital station for the study of space and Earth information science. The station can be used to detect and record the information transmitted from satellites in the outer space. The station can monitor landslide, subsidence, earthquakes, typhoons and floods effectively, which reduce the loss of human lives and properties due to these natural disasters. Since the station is situated at the United College and its shape resembles a ball, it is also named the UC Ball.";
        }

        //Chapel
        else if (ID == 19)
        {
            return "The Chung Chi College Chapel is the oldest and the largest independent chapel amongst public college campuses across China. Woodcuts of thirteen Chinese Christian colleges' emblems are placed beside the altar. Weekly assemblies are organized every Friday to cultivate students' virtues and moral conducts. There are also numerous fellowship groups that organize religious activities and provide support to students. In addition, the chapel organizes music activities such as choral singing, organ music appreciation every week to alleviate the stress that students and staff are facing.";
        }


        //The Four Pillars
        else if (ID == 20)
        {
            return "The Four Pillars are located one of the entrances of the Chinese University of Hong Kong from the Tai Po road. No physical walls are located at this entrance, which symbolizes that the spirit that there is no barrier between the university and society. The Four Pillars were built in 1974 with a donation of HKD $310,000. The formal name of the \"pillars\" is huabiao, which is a type of Chinese ceremonial columns. The simple shapes of huabiaos symbolize the freedom and transparency of the university. In the early years, when the frequency of the train service was still relatively low, students prefered commuting by buses or mini-buses and entering the campus through the Tai Po road. Nowadays, the MTR system is well-developed and it is more favourable to commute by train for most students.";
        }

        //
        else return "";
        }
}
