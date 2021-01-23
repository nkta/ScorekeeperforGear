/*
 * Football.cpp
 *
 *  Created on: May 9, 2017
 *      Author: koudota-y
 */

#include <sport_inc/Football.h>

Football::Football():sport() {
	nameSport = "Football";
	setWinNbr = Configuration::readconfig("Football");
	user_point = NOT_USED;
	opponent_point = NOT_USED;
	user_set = NOT_USED;
	opponent_set = NOT_USED;
	// TODO Auto-generated constructor stub

}

bool Football::count_score(int i){
	if(i == 0){
		user_score++;
	}else if (i == 1) {
		opponent_score++;
	}
	return false;
}

bool Football::count_point(int i) {
	return false;
}

bool Football::count_set(int i){
	if(i == 0){
		user_set++;
	}else if (i == 1) {
		opponent_set++;
	}
	return false;
}

Football::~Football() {
	// TODO Auto-generated destructor stub
}

