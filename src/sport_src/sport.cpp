/*
 * sport.cpp
 *
 *  Created on: May 3, 2017
 *      Author: nicolas
 */

#include <sport_inc/sport.h>
#include <vector>

sport::sport() {
	user_score = 0;
	opponent_score = 0;
	user_point = 0;
	opponent_point = 0;
	user_set = 0;
	opponent_set = 0;
	isWinUser = false;
	isWinOpponent = false;

}

void sport::reset_score(){
	user_score  = (user_score != NOT_USED) ? 0: NOT_USED;
	opponent_score = (opponent_score != NOT_USED) ? 0: NOT_USED;
	user_point = (user_point != NOT_USED) ? 0: NOT_USED;
	opponent_point = (opponent_point != NOT_USED) ? 0: NOT_USED;
	user_set = (user_set != NOT_USED) ? 0: NOT_USED;
	opponent_set = (opponent_set != NOT_USED) ? 0: NOT_USED;
	isWinUser = false;
	isWinOpponent = false;
	tabScoreUser.clear();
	tabScoreOpponent.clear();
	tabStrScoreUser.clear();
	tabStrScoreOpponent.clear();
}

void sport::set_tabScore(int userScore, int opponentScore){
	char buf[128];
	tabScoreUser.push_back(userScore);
	tabScoreOpponent.push_back(opponentScore);
	(userScore<10)?sprintf(buf,"0%d",userScore) : sprintf(buf,"%d",userScore);
	tabStrScoreUser.push_back(strdup(buf));
	(opponentScore<10)?sprintf(buf,"0%d",opponentScore) : sprintf(buf,"%d",opponentScore);
	tabStrScoreOpponent.push_back(strdup(buf));
}
int sport::get_user_score(){
	return user_score;
}

int sport::get_opponent_score(){
	return opponent_score;
}

int sport::get_user_point(){
	return user_point;
}

int sport::get_opponent_point(){
	return opponent_point;
}

int sport::get_user_set(){
	return user_set;
}

int sport::get_opponent_set(){
	return opponent_set;
}

int sport::get_setWinNbr(){
	return setWinNbr;
}

void sport::set_setWinNbr(int nb){
	setWinNbr  = nb;
}

bool sport::get_isWinUser(){
	return isWinUser;
}
bool sport::get_isWinOpponent(){
	return isWinOpponent;
}

std::vector<int> sport::get_tabScoreUser(){
	return tabScoreUser;
}


std::vector<int> sport::get_tabScoreOpponent(){
	return tabScoreOpponent;
}

char* sport::get_str_tabScoreUser(){
	std::stringstream result;
	std::copy(tabStrScoreUser.begin(), tabStrScoreUser.end(), std::ostream_iterator<char*>(result, " "));
	return strdup(result.str().c_str());
}
char* sport::get_str_tabScoreOpponent(){
	std::stringstream result;
	std::copy(tabStrScoreOpponent.begin(), tabStrScoreOpponent.end(), std::ostream_iterator<char*>(result, " "));
	return strdup(result.str().c_str());
}

std::string sport::get_nameSport(){
	return nameSport;
}
char* sport::get_str_user_score(){
	char buf[128];
	if(user_score != NOT_USED){
		snprintf (buf,127,"%d",user_score);
	}else{
		snprintf (buf,127,"-");
	}
	return strdup(buf);
}
char* sport::get_str_opponent_score(){
	char buf[128];
	if(opponent_score != NOT_USED){
		snprintf (buf,127,"%d",opponent_score);
	}else{
		snprintf (buf,127,"-");
	}
	return strdup(buf);
}

char* sport::get_str_user_point(){
	char buf[128];
	if(user_point != NOT_USED){
		snprintf (buf,127,"%d",user_point);
	}else{
		snprintf (buf,127,"-");
	}
	return strdup(buf);
}
char* sport::get_str_opponent_point(){
	char buf[128];
	if(opponent_point != NOT_USED){
		snprintf (buf,127,"%d",opponent_point);
	}else{
		snprintf (buf,127,"-");
	}
	return strdup(buf);
}
char* sport::get_str_user_set(){
	char buf[128];
	if(user_set != NOT_USED){
		snprintf (buf,127,"%d",user_set);
	}else{
		snprintf (buf,127,"-");
	}
	return strdup(buf);
}
char* sport::get_str_opponent_set(){
	char buf[128];
	if(opponent_set != NOT_USED){
		snprintf (buf,127,"%d",opponent_set);
	}else{
		snprintf (buf,127,"-");
	}
	return strdup(buf);
}

sport::~sport() {
	// TODO Auto-generated destructor stub
}

