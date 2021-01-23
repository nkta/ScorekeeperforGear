/*
 * PingPong.cpp
 *
 *  Created on: May 9, 2017
 *      Author: koudota-y
 */

#include <sport_inc/PingPong.h>

PingPong::PingPong():sport() {
	nameSport = "PingPong";
	setWinNbr = Configuration::readconfig("PingPong");
	user_point = NOT_USED;
	opponent_point = NOT_USED;
	// TODO Auto-generated constructor stub

}

bool PingPong::count_score(int i){
	if(i == 0){
		user_score++;
		if(user_score==11 && opponent_score < 10 || user_score >= 10 && opponent_score >= 10 && user_score == (opponent_score + 2)){
			count_set(i);
			user_score=0;
			opponent_score=0;

		}
	}else if (i == 1) {
		opponent_score++;
		if(opponent_score==11 && user_score < 10 || opponent_score >= 10 && user_score >= 10 && opponent_score == (user_score + 2)){
			count_set(i);
			opponent_score=0;
			user_score=0;

		}
	}
	return false;
}
bool PingPong::count_point(int i) {

	return false;
}
bool PingPong::count_set(int i){
	if(i == 0){
		user_set++;
		if(user_set == setWinNbr){
			isWinUser = true;
		}
	}else if(i == 1){
		opponent_set++;
		if(opponent_set == setWinNbr){
			isWinOpponent = true;
		}
	}
	set_tabScore(user_score, opponent_score);
	return false;

}

PingPong::~PingPong() {
	// TODO Auto-generated destructor stub
}

