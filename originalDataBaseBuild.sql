create schema TickTockOverClock;
use TickTockOverClock;
CREATE TABLE `questions` (
  `id` mediumint(8) unsigned NOT NULL auto_increment,
  `username` varchar(255) default NULL,
  `title` varchar(255) default NULL,
  `details` varchar(1000) default NULL,
  `posted` datetime default NULL,
  `tags` varchar(255),
  `status` mediumint(8),
  PRIMARY KEY (`id`)
) AUTO_INCREMENT=1;
CREATE TABLE `answers` (
  `id` mediumint(8) unsigned NOT NULL auto_increment,
  `username` varchar(255) default NULL,
  `details` varchar(1000) default NULL,
  `qid` mediumint(8),
  `posted` datetime default NULL,
  `upvotes` mediumint(8),
  PRIMARY KEY (`id`)
) AUTO_INCREMENT=1;
INSERT INTO `questions` (`username`,`title`,`details`,`posted`, `tags`, `status`) VALUES ("myOneMissedShot","Associate Dev","How can you make two different sounds at the same time?","2016-05-29","music, talent, multitask", 0);

INSERT INTO `questions` (`username`,`title`,`details`,`posted`, `tags`, `status`) VALUES ("neverMindTheCurtain","Dev","How can I make a table with random answers to fill in this table?","2013-07-05","music, talent, multitask", 0);
INSERT INTO `questions` (`username`,`title`,`details`,`posted`, `tags`, `status`) VALUES ("rustyAtBest","Senior Dev","What velocity will my computer reach when I hurl it out of the window if I'm on the 15th floor (150 feet elevation)?",now(),"music, talent, multitask", 0);
INSERT INTO `questions` (`username`,`title`,`details`,`posted`, `tags`, `status`) VALUES ("iHopeIDontRoll1","Associate Dev","How do I know I'm on the right floor for work?","2020-01-06","music, talent, multitask", 0);
INSERT INTO `questions` (`username`,`title`,`details`,`posted`, `tags`, `status`) VALUES ("clocksTickTwice","Dev","How can I get video to play from my webcam?","2015-12-30","music, talent, multitask", 0);

INSERT INTO `answers` (`username`,`details`,`qid`, `posted`, `upvotes`) VALUES ("bleedingAC#Cut","Capentry. Decent amount of wood. After you build it you'll need to write out random things on paper.", 2, "2017-03-12", 0);
INSERT INTO `answers` (`username`,`details`,`qid`, `posted`, `upvotes`) VALUES ("democraticWolfPack","You can hum with your mouth open and lips pursed. From there you can whistle and hum at the same time.", 1, "2018-11-23", 0);
INSERT INTO `answers` (`username`,`details`,`qid`, `posted`, `upvotes`) VALUES ("birdsWithOutWings","This is vague. Do you mean on the screen for a teams meeting or play video that was taken on your webcam?", 5, "2017-07-23", 0);
INSERT INTO `answers` (`username`,`details`,`qid`, `posted`, `upvotes`) VALUES ("mediumSide","You don't. Are you sure you aren't supposed to be on the left floor for work?", 4, "2021-02-22", 0);
INSERT INTO `answers` (`username`,`details`,`qid`, `posted`, `upvotes`) VALUES ("gotMemoriesOlderThanYou","98.25 ft per second depending if you don't give it any downward momentum in the throw.", 3, now(), 0);
INSERT INTO `answers` (`username`,`details`,`qid`, `posted`, `upvotes`) VALUES ("spotIcles","You'd spend more time coming up with that than just filling in this table.", 2, "2019-05-11", 0);
INSERT INTO `answers` (`username`,`details`,`qid`, `posted`, `upvotes`) VALUES ("bluntForcePush","Look for people that you know. Don't see anyone? Try another floor.", 4, "2021-02-22", 0);
INSERT INTO `answers` (`username`,`details`,`qid`, `posted`, `upvotes`) VALUES ("silentTagGame","Scream in frustration and at the same time knock all the things off your desk.", 1, "2017-03-12", 0);
INSERT INTO `answers` (`username`,`details`,`qid`, `posted`, `upvotes`) VALUES ("dontAskABearItsBestFeature","Go to device settings, video in teams. There should be a preview box.", 5, "2018-03-22", 0);
INSERT INTO `answers` (`username`,`details`,`qid`, `posted`, `upvotes`) VALUES ("dignityDownTheDrain","Well if there isn't anyone in the office or outside the office I know it won't make a sound.", 3, "2021-05-24", 0);
