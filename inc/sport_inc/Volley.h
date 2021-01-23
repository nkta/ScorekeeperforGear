/*
 * Volley.h
 *
 *  Created on: May 9, 2017
 *      Author: koudota-y
 */

#ifndef SPORT_INC_VOLLEY_H_
#define SPORT_INC_VOLLEY_H_

#include <sport_inc/sport.h>

class Volley: public sport {
public:
	Volley();
	virtual bool count_score(int i);
	virtual bool count_point(int i);
	virtual bool count_set(int i);
	virtual ~Volley();
private:
	bool lastSet;
};

#endif /* SPORT_INC_VOLLEY_H_ */
