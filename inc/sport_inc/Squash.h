/*
 * Squash.h
 *
 *  Created on: May 9, 2017
 *      Author: koudota-y
 */

#ifndef SPORT_INC_SQUASH_H_
#define SPORT_INC_SQUASH_H_

#include <sport_inc/sport.h>

class Squash: public sport {
public:
	Squash();
	virtual bool count_score(int i);
	virtual bool count_point(int i);
	virtual bool count_set(int i);
	virtual ~Squash();
};

#endif /* SPORT_INC_SQUASH_H_ */
