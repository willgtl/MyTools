/*
Navicat MySQL Data Transfer

Source Server         : MySQL
Source Server Version : 50515
Source Host           : localhost:3306
Source Database       : a

Target Server Type    : MYSQL
Target Server Version : 50515
File Encoding         : 65001

Date: 2011-12-10 05:41:32
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `npc_vendor_temp`
-- ----------------------------
DROP TABLE IF EXISTS `npc_vendor_temp`;
CREATE TABLE `npc_vendor_temp` (
  `entry` mediumint(8) unsigned NOT NULL DEFAULT '0',
  `slot` smallint(6) NOT NULL DEFAULT '0',
  `item` mediumint(8) NOT NULL DEFAULT '0',
  `maxcount` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `incrtime` int(10) unsigned NOT NULL DEFAULT '0',
  `ExtendedCost` mediumint(8) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`entry`,`item`,`ExtendedCost`),
  KEY `slot` (`slot`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 ROW_FORMAT=FIXED COMMENT='Npc System';

-- ----------------------------
-- Records of npc_vendor_temp
-- ----------------------------
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77710', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77682', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77670', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77671', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77667', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77712', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77709', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77695', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77701', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77697', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77700', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77692', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77694', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77679', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77678', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77669', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77666', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77668', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77708', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77713', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77711', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77699', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77698', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77696', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77693', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77691', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77690', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77683', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77681', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77680', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77601', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77745', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77602', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77649', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77847', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77648', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77848', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77633', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77811', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77638', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77812', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77628', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77797', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77630', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77799', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77618', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77777', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77614', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77785', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77599', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77603', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77720', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77721', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77651', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77650', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77733', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77732', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77637', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77634', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77731', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77730', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77632', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77627', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77728', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77729', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77616', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77617', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77725', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77724', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77619', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77629', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77598', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77742', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77748', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77600', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77844', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77647', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77850', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77652', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77820', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77813', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77636', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77635', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77631', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77800', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77801', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77784', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77615', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77604', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77605', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77639', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77640', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77620', '0', '0', '0');
INSERT INTO `npc_vendor_temp` VALUES ('40209', '0', '77787', '0', '0', '0');
