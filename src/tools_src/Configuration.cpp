/*
 * Configuration.cpp
 *
 *  Created on: Jun 15, 2017
 *      Author: koudota-y
 */

#include "tools_inc/Configuration.h"

char* Configuration::destinationConfigFilePath(){
    char file_path_dest[100];
    std::string versionValue_str;
    char *versionValue=NULL;
    system_info_get_platform_string("http://tizen.org/feature/platform.native.api.version", &versionValue);
    versionValue_str=versionValue;
    if(versionValue_str.at(0)-'0'< 3){
		if(2 < 3){
			sprintf(file_path_dest, "%sconfig.cfg", CONFIG_DIR_TIZEN_2);
		}else{
			sprintf(file_path_dest, "%sconfig.cfg", CONFIG_DIR_TIZEN_3);
		}
		return strdup(file_path_dest);
    }
}

int Configuration::createConfigurationTextFile(){
    FILE* fSrc;
    FILE* fDest;
    char buffer[512];
    int NbLus;


	char file_path_src[100];
	sprintf(file_path_src, "%sconfig.cfg", app_get_resource_path());
	std::ifstream fichier( destinationConfigFilePath() );
	if(!fichier.fail()) return -1;
    if ((fSrc = fopen(file_path_src, "rb")) == NULL)
    {
        return 1;
    }

    if ((fDest = fopen(destinationConfigFilePath(), "w+")) == NULL)
    {
        fclose(fSrc);
        return 2;
    }

    while ((NbLus = fread(buffer, 1, 512, fSrc)) != 0)
        fwrite(buffer, 1, NbLus, fDest);

    fclose(fDest);
    fclose(fSrc);

    return 0;
}

int Configuration::readconfig(std::string key){
	   FILE * pFile;

	   char buffer [100];
	   std::string line;
	   std::string key1;
	   std::string value;
	   int posEqual;
	   int a=0;
	   int value_int;
	   char file_path[100];
	   sprintf(file_path, "%sconfig.cfg", app_get_resource_path());
	  // pFile = fopen(file_path , "r");
	   pFile = fopen(destinationConfigFilePath() , "r");
	   if (pFile == NULL) return -1;
	   else
	   {
	     while ( ! feof (pFile) )
	     {
	    	 if ( fgets (buffer , 100 , pFile) == NULL ) break;
	    	 a++;
			 line = buffer;
			 posEqual=line.find('=');
			 key1  = line.substr(0,posEqual);
			 if(strcmp(key1.c_str(),key.c_str())==0){
				 value = line.substr(posEqual+1,10);
				 return std::stoi(value);
			 }
	     }
	     fclose (pFile);
	   }
	   return -1;

}

void Configuration::writeConfig(std::string key,int new_value){
	   FILE* pFile = NULL;
	   char file_path[100];
	   sprintf(file_path, "%sconfig.cfg", app_get_resource_path());
	   pFile = fopen(destinationConfigFilePath(),"r");
	   char buffer [100];
	   std::string line;
	   std::vector<std::string> key_tmp;
	   std::vector<std::string> value_tmp;
	   std::string key1;
	   std::string value;
	   int value_int;
	   char tmp[100];
	   int posEqual;
	   int a=0;
	   if (pFile != NULL)
	   {
	     while ( ! feof (pFile) )
	     {
	    	 if ( fgets (buffer , 100 , pFile) == NULL ) break;
	    	 a++;
			 line = buffer;
			 posEqual=line.find('=');
			 key1=line.substr(0,posEqual);
			 key_tmp.push_back(key1);
			 if(strcmp(key1.c_str(),key.c_str())==0){
				 sprintf(tmp, "%d", new_value);
				 value_tmp.push_back(tmp);
			 }else{
				 value=line.substr(posEqual+1,10);
				 sprintf(tmp, "%d", std::stoi(value));
				 value_tmp.push_back(tmp);
			 }
	     }
	   }
       fclose(pFile);
       pFile = fopen(destinationConfigFilePath(),"w");
       for(int i=0;i<key_tmp.size();i++){
    	   fprintf(pFile,"%s=%s\n",key_tmp[i].c_str(),value_tmp[i].c_str());
       }
       fclose(pFile);
}
