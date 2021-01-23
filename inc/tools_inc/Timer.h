/*
 * Timer.h
 *
 *  Created on: Apr 27, 2017
 *      Author: nicolas
 */

#include <time.h>
#include <string.h>
#include <string>
#include <Ecore.h>

#ifndef TOOLS_SRC_TIMER_H_
#define TOOLS_SRC_TIMER_H_

class Timer {
public:
	Timer();
	void startTimer(double in, Ecore_Task_Cb func, const void *data);
	void pauseTimer();
	void resumeTimer();
	void continueTimer();
	void resetTimer();
	void stopTimer();
	void localCurrentTime();
	void actualiseTimer();
	double getCurrentTime();
	void convertTimer();
	int GetHour();
	int GetMin();
	int GetSec();
	int GetLocalHour();
	int GetLocalMin();
	char* GetStrLocalTime();
	char* GetStrTimer();
	bool isRunning();
	virtual ~Timer();

private:
	time_t init_time;
	time_t curent_time;
	int hour_timer;
	int min_timer;
	int sec_timer;
	double lapsdiffTime;
	struct tm* time_info;
	Ecore_Timer* timer;
	bool TimerState;
};


#endif /* TOOLS_SRC_TIMER_H_ */
