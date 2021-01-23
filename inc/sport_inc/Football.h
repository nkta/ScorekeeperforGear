/*
 * Football.h
 *
 *  Created on: May 9, 2017
 *      Author: koudota-y
 */

#ifndef SPORT_INC_FOOTBALL_H_
#define SPORT_INC_FOOTBALL_H_

#include <sport_inc/sport.h>

class Football: public sport {
public:
	Football();
	virtual bool count_score(int i);
	virtual bool count_point(int i);
	virtual bool count_set(int i);
	virtual ~Football();
};

#endif /* SPORT_INC_FOOTBALL_H_ */
