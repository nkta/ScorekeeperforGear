/*
 * Volley.cpp
 *
 *  Created on: May 9, 2017
 *      Author: koudota-y
 */

#include <sport_inc/Volley.h>

Volley::Volley():sport() {
	nameSport = "Volley";
	setWinNbr = Configuration::readconfig("Volley");
	user_point = NOT_USED;
	opponent_point = NOT_USED;
	lastSet = false;
	// TODO Auto-generated constructor stub

}

bool Volley::count_score(int i){
	int score_set = 0;
	if(lastSet){
		score_set = 15;
	}else{
		score_set = 25;
	}
	if(i == 0){
		user_score++;
		if(user_score==score_set && opponent_score < (score_set - 1) || user_score >= (score_set - 1) && opponent_score >= (score_set-1) && user_score == (opponent_score + 2)){
			count_set(i);
			user_score=0;
			opponent_score=0;
		}
	}else if (i == 1) {
		opponent_score++;
		if(opponent_score==score_set && user_score < (score_set - 1) || opponent_score >= (score_set - 1) && user_score >= (score_set - 1) && opponent_score == (user_score + 2)){
			count_set(i);
			opponent_score=0;
			user_score=0;
		}
	}
	return false;
}

bool Volley::count_point(int i) {

	return false;
}

bool Volley::count_set(int i){
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
	if(user_set == (setWinNbr - 1) && opponent_set == (setWinNbr - 1)){
		lastSet = true;
	}
	set_tabScore(user_score, opponent_score);
	return false;
}

Volley::~Volley() {
	// TODO Auto-generated destructor stub
}

