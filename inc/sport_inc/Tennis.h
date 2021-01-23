/*
 * Tennis.h
 *
 *  Created on: May 9, 2017
 *      Author: koudota-y
 */

#ifndef SPORT_INC_TENNIS_H_
#define SPORT_INC_TENNIS_H_

#include <sport_inc/sport.h>

class Tennis: public sport {
public:
	Tennis();
	virtual bool count_score(int i);
	virtual bool count_point(int i);
	virtual bool count_set(int i);
	virtual char* get_str_user_score();
	virtual char* get_str_opponent_score();
	virtual ~Tennis();

private:
	bool lastSet;
	bool tieBreak;
};

#endif /* SPORT_INC_TENNIS_H_ */
