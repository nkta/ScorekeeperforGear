/*
 * Badminton.cpp
 *
 *  Created on: May 4, 2017
 *      Author: nicolas
 */

#include <sport_inc/sport.h>
#include "sport_inc/Badminton.h"


Badminton::Badminton():sport(){
	nameSport = "Badminton";
	setWinNbr = Configuration::readconfig("Badminton");
	user_point = NOT_USED;
	opponent_point = NOT_USED;
	// TODO Auto-generated constructor stub

}

bool Badminton::count_score(int i){
	if(i == 0){
		user_score++;
		if(user_score==21 && opponent_score < 20 || user_score == 30 || user_score >= 20 && opponent_score >= 20 && user_score == (opponent_score + 2)){
			count_set(i);
			user_score=0;
			opponent_score=0;

		}
	}else if (i == 1) {
		opponent_score++;
		if(opponent_score==21 && user_score < 20 || opponent_score == 30 || opponent_score >= 20 && user_score >= 20 && opponent_score == (user_score + 2)){
			count_set(i);
			opponent_score=0;
			user_score=0;
		}
	}
	return false;
}
bool Badminton::count_point(int i) {

	return false;
}
bool Badminton::count_set(int i){
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

Badminton::~Badminton() {
	// TODO Auto-generated destructor stub
}

