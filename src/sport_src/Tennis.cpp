/*
 * Tennis.cpp
 *
 *  Created on: May 9, 2017
 *      Author: koudota-y
 */

#include <sport_inc/Tennis.h>

Tennis::Tennis():sport() {
	nameSport = "Tennis";
	setWinNbr = Configuration::readconfig("Tennis");
	lastSet=false;
	tieBreak = false;
	// TODO Auto-generated constructor stub

}
bool Tennis::count_score(int i){
	if(i == 0){
		user_score++;
		if(user_score == 4 && opponent_score == 4 && !tieBreak){
			opponent_score--;
			user_score--;
		}
		if((user_score == 4 && opponent_score < 3 || user_score == 5) && !tieBreak || (user_score == 7 && opponent_score <= 5 || user_score > 7 && opponent_score > 7 && user_score == (opponent_score + 2) ) && tieBreak ){
			user_score=0;
			opponent_score=0;
			count_point(i);
		}
	}else if (i == 1) {
		opponent_score++;
		if(user_score == 4 && opponent_score == 4 && !tieBreak){
			user_score--;
			opponent_score--;
		}
		if((opponent_score == 4 &&  user_score < 3 || opponent_score == 5) && !tieBreak || (opponent_score == 7 &&  user_score <= 5 || opponent_score > 7 &&  user_score > 7 && opponent_score == ( user_score + 2) ) && tieBreak){
			opponent_score=0;
			user_score=0;
			count_point(i);
		}
	}
	return false;
}
bool Tennis::count_point(int i) {
	if (i==0) {
		user_point++;
		if (user_point == 6 && opponent_point < 5 || (user_point == 7 && !lastSet) || (user_point >= 5 && opponent_point >= 5 && user_point == opponent_point+2 && lastSet)) {
			opponent_point=0;
			user_point=0;
			count_set(i);
			tieBreak=false;
		}
	}else if (i==1) {
		opponent_point++;
		if (opponent_point == 6 && user_point < 5 || (opponent_point == 7 && !lastSet) || (user_point >= 5 && opponent_point >= 5 && opponent_point == user_point+2 && lastSet)) {
			opponent_point=0;
			user_point=0;
			count_set(i);
			tieBreak=false;
		}
	}
	if(user_point == 6 && opponent_point == 6 && !lastSet){
		tieBreak=true;
	}
	return false;
}
bool Tennis::count_set(int i){
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
	set_tabScore(user_point, opponent_point);
	return false;
}

char* Tennis::get_str_user_score(){
	char buf[128];
	if(!tieBreak){
		switch(user_score){
		    case 0:
		    	snprintf (buf,127,"0");
		    	break;
			case 1:
				snprintf (buf,127,"15");
				break;
			case 2:
				snprintf (buf,127,"30");
				break;
			case 3:
				snprintf (buf,127,"40");
				break;
			case 4:
				snprintf (buf,127,"AD");

		}
	}else {
		snprintf (buf,127,"%d",user_score);
	}

	return strdup(buf);
}

char* Tennis::get_str_opponent_score(){
	char buf[128];
	if(!tieBreak){
		switch(opponent_score){
		    case 0:
		    	snprintf (buf,127,"0");
		    	break;
			case 1:
				snprintf (buf,127,"15");
				break;
			case 2:
				snprintf (buf,127,"30");
				break;
			case 3:
				snprintf (buf,127,"40");
				break;
			case 4:
				snprintf (buf,127,"AD");

		}
	}else {
		snprintf (buf,127,"%d",opponent_score);
	}

	return strdup(buf);
}

Tennis::~Tennis() {
	// TODO Auto-generated destructor stub
}

