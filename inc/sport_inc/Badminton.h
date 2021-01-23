/*
 * Badminton.h
 *
 *  Created on: May 4, 2017
 *      Author: nicolas
 */

#ifndef SPORT_SRC_BADMINTON_H_
#define SPORT_SRC_BADMINTON_H_

class Badminton : public sport {
public:
	Badminton();
	virtual bool count_score(int i);
	virtual bool count_point(int i);
	virtual bool count_set(int i);
	virtual ~Badminton();
};

#endif /* SPORT_SRC_BADMINTON_H_ */
