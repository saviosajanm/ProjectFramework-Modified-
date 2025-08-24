#
# Table structure for table 'settings_tb'
#

DROP TABLE IF EXISTS `settings_tb`;

CREATE TABLE `settings_tb` (
  `ID` INTEGER NOT NULL AUTO_INCREMENT,
  `SettingsKey` VARCHAR(50),
  `SettingsValue` LONGTEXT,
  `Reserved1` LONGTEXT,
  PRIMARY KEY (`ID`),
  INDEX (`SettingsKey`)
) ENGINE=myisam DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'settings_tb'
#

INSERT INTO `settings_tb` (`ID`, `SettingsKey`, `SettingsValue`, `Reserved1`) VALUES (1, 'MainHeading', 'ASP.NET Project Framework', NULL);
INSERT INTO `settings_tb` (`ID`, `SettingsKey`, `SettingsValue`, `Reserved1`) VALUES (2, 'MainDesc', 'ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript. This information is taken from settings_tb , MainDesc Key.', NULL);
INSERT INTO `settings_tb` (`ID`, `SettingsKey`, `SettingsValue`, `Reserved1`) VALUES (3, 'AppName', 'App Name ', NULL);
INSERT INTO `settings_tb` (`ID`, `SettingsKey`, `SettingsValue`, `Reserved1`) VALUES (4, 'EnableMobAuth', 'False', NULL);
INSERT INTO `settings_tb` (`ID`, `SettingsKey`, `SettingsValue`, `Reserved1`) VALUES (5, 'SMTPServer', 'smtp.example.com', NULL);
INSERT INTO `settings_tb` (`ID`, `SettingsKey`, `SettingsValue`, `Reserved1`) VALUES (6, 'SMTPPort', '587', NULL);
INSERT INTO `settings_tb` (`ID`, `SettingsKey`, `SettingsValue`, `Reserved1`) VALUES (7, 'EMail', 'user@example.com', NULL);
INSERT INTO `settings_tb` (`ID`, `SettingsKey`, `SettingsValue`, `Reserved1`) VALUES (8, 'EmailPassword', 'password', NULL);
INSERT INTO `settings_tb` (`ID`, `SettingsKey`, `SettingsValue`, `Reserved1`) VALUES (9, 'EnableSSL', 'true', NULL);
INSERT INTO `settings_tb` (`ID`, `SettingsKey`, `SettingsValue`, `Reserved1`) VALUES (10, 'Device_ProcessorCount', '0', NULL);
INSERT INTO `settings_tb` (`ID`, `SettingsKey`, `SettingsValue`, `Reserved1`) VALUES (11, 'Device_TotalMemory', 'N/A', NULL);
INSERT INTO `settings_tb` (`ID`, `SettingsKey`, `SettingsValue`, `Reserved1`) VALUES (12, 'Device_MemoryLeft', 'N/A', NULL);
INSERT INTO `settings_tb` (`ID`, `SettingsKey`, `SettingsValue`, `Reserved1`) VALUES (13, 'Device_TotalSpace', 'N/A', NULL);
INSERT INTO `settings_tb` (`ID`, `SettingsKey`, `SettingsValue`, `Reserved1`) VALUES (14, 'Device_SpaceLeft', 'N/A', NULL);


#
# Table structure for table 'user_info_tb'
#

DROP TABLE IF EXISTS `user_info_tb`;

CREATE TABLE `user_info_tb` (
  `ID` INTEGER NOT NULL AUTO_INCREMENT,
  `FirstName` VARCHAR(50),
  `LastName` VARCHAR(50),
  `UserName` VARCHAR(100),
  `Email` VARCHAR(100),
  `PhoneNo` VARCHAR(50),
  `Address` LONGTEXT,
  `Password` VARCHAR(50),
  `Role` VARCHAR(15),
  `OrgID` INTEGER DEFAULT 0,
  `AdditionalUserInfo` LONGTEXT,
  `Reserved1` LONGTEXT,
  PRIMARY KEY (`ID`),
  INDEX (`OrgID`)
) ENGINE=myisam DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'user_info_tb'
#

INSERT INTO `user_info_tb` (`ID`, `FirstName`, `LastName`, `UserName`, `Email`, `PhoneNo`, `Address`, `Password`, `Role`, `OrgID`, `AdditionalUserInfo`, `Reserved1`) VALUES (1, 'Site', 'Admin', 'admin', 'admin@yourcompany.com', '9853536855', 'Pala | Kerala | India', 'aLbQNeqrkDA=', 'Admin', NULL, NULL, NULL);


#
# Table structure for table 'home_page_boxes_tb'
#

DROP TABLE IF EXISTS `home_page_boxes_tb`;

CREATE TABLE `home_page_boxes_tb` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Heading` varchar(255) DEFAULT NULL,
  `SubHeading` text,
  `Link` varchar(255) DEFAULT NULL,
  `DisplayOrder` int(11) DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'home_page_boxes_tb'
#

INSERT INTO `home_page_boxes_tb` (`ID`, `Heading`, `SubHeading`, `Link`, `DisplayOrder`) VALUES (1, 'Getting started', 'This ASP.NET Web Project Framework lets you build dynamic websites using a familiar drag-and-drop, event-driven model. A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.', 'http://training.ktsinfotech.com', 1);
INSERT INTO `home_page_boxes_tb` (`ID`, `Heading`, `SubHeading`, `Link`, `DisplayOrder`) VALUES (2, 'Database Support', 'Database Support is Given For OLD DB Database as well as ODBC Based Databases . Default Database script in App_Data Folder for MS Access and MySQL. The site default user name / password is admin / admin', 'http://training.ktsinfotech.com', 2);
INSERT INTO `home_page_boxes_tb` (`ID`, `Heading`, `SubHeading`, `Link`, `DisplayOrder`) VALUES (3, 'Web Hosting', 'You can easily find a web hosting company that offers the right mix of features and price for your applications. Some of the Hosting providers for which this Site Framework tested includes Shared Hosting Servers like Godaddy , Hostgator and Dedicated Servers like Amazon Lightsail etc.', 'http://training.ktsinfotech.com', 3);