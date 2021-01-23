/*
 * PingPong.h
 *
 *  Created on: May 9, 2017
 *      Author: koudota-y
 */

#ifndef SPORT_INC_PINGPONG_H_
#define SPORT_INC_PINGPONG_H_

#include <sport_inc/sport.h>

class PingPong: public sport {
public:
	PingPong();
	virtual bool count_score(int i);
	virtual bool count_point(int i);
	virtual bool count_set(int i);
	virtual ~PingPong();
};

#endif /* PINGPONG_H_ */
