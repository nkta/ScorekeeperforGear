/*
 * Squash.cpp
 *
 *  Created on: May 9, 2017
 *      Author: koudota-y
 */

#include <sport_inc/Squash.h>

Squash::Squash():sport() {
	nameSport = "Squash";
	setWinNbr = Configuration::readconfig("Squash");
	user_point = NOT_USED;
	opponent_point = NOT_USED;
	// TODO Auto-generated constructor stub

}

bool Squash::count_score(int i){
	if(i == 0){
		user_score++;
		if(user_score==11 && opponent_score < 10 || user_score >= 10 && opponent_score >= 10 && user_score == (opponent_score + 2)){
			user_score=0;
			opponent_score=0;
			user_set++;
		}
	}else if (i == 1) {
		opponent_score++;
		if(opponent_score==11 && user_score < 10 || opponent_score >= 10 && user_score >= 10 && opponent_score == (user_score + 2)){
			opponent_score=0;
			user_score=0;
			opponent_set++;
		}
	}
	return false;
}

bool Squash::count_point(int i) {

	return false;
}

bool Squash::count_set(int i){
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

Squash::~Squash() {
	// TODO Auto-generated destructor stub
}

