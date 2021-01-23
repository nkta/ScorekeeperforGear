/*
 * sport.h
 *
 *  Created on: May 3, 2017
 *      Author: nicolas
 */

#ifndef SPORT_INC_SPORT_H_
#define SPORT_INC_SPORT_H_

#include "tools_inc/Configuration.h"
#include <cstddef>
#include <string.h>
#include <string>
#include <vector>
#include <algorithm>
#include <sstream>
#include <iterator>
#include <iostream>

#define NOT_USED -1

class sport {
public:
	sport();
	virtual bool count_score(int i) = 0;
	virtual bool count_point(int i) = 0;
	virtual bool count_set(int i) = 0;
	void reset_score();
	int get_user_score();
	int get_opponent_score();
	int get_user_point();
	int get_opponent_point();
	int get_user_set();
	int get_opponent_set();
	int get_setWinNbr();
	void set_setWinNbr(int nb);
	bool get_isWinUser();
	bool get_isWinOpponent();
	std::vector<int> get_tabScoreUser();
	std::vector<int> get_tabScoreOpponent();
	char* get_str_tabScoreUser();
	char* get_str_tabScoreOpponent();
	void set_tabScore(int userScore, int oppnentScore);
	std::string get_nameSport();
	virtual char* get_str_user_score();
	virtual char* get_str_opponent_score();
	virtual char* get_str_user_point();
	virtual char* get_str_opponent_point();
	virtual char* get_str_user_set();
	virtual char* get_str_opponent_set();

	virtual ~sport();

protected:
	int user_score;
	int opponent_score;
	int user_point;
	int opponent_point;
	int user_set;
	int opponent_set;
	int setWinNbr;
	bool isWinUser;
	bool isWinOpponent;
	std::vector<int> tabScoreUser;
	std::vector<int> tabScoreOpponent;
	std::vector<char*> tabStrScoreUser;
	std::vector<char*> tabStrScoreOpponent;
	std::string nameSport;

};

#endif /* SPORT_INC_SPORT_H_ */
