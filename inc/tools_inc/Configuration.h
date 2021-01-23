/*
 * Configuration.h
 *
 *  Created on: Jun 15, 2017
 *      Author: koudota-y
 */

#ifndef TOOLS_INC_CONFIGURATION_H_
#define TOOLS_INC_CONFIGURATION_H_

#include <iostream>
#include <fstream>
#include <Sstream>
#include <String>
#include <string.h>
#include <dlog.h>
#include <stdio.h>
#include <glib.h>
#include <dlog.h>
#include <app_common.h>
#include <vector>
#include <storage.h>
#include <system_info.h>
//using namespace std;

#define CONFIG_DIR_TIZEN_2 "/opt/usr/media/Documents/"
#define CONFIG_DIR_TIZEN_3 "/opt/usr/home/owner/data/"
//#define CONFIG_DIR "data/"

class Configuration {
public:
	static char* destinationConfigFilePath();
	static int createConfigurationTextFile();
	static int readconfig(std::string key);
	static void writeConfig(std::string key,int value);
};

#endif /* TOOLS_SRC_CONFIGURATION_H_ */
