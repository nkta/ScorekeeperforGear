/*
 * Timer.cpp
 *
 *  Created on: Apr 27, 2017
 *      Author: nicolas
 */

#include <tools_inc/Timer.h>
#include <time.h>
#include <math.h>
#include <tizen.h>

Timer::Timer() {
	// TODO Auto-generated constructor stub
	TimerState = false;
	init_time=0;
	time(&curent_time);
}

void Timer::startTimer(double in, Ecore_Task_Cb func, const void *data){
	TimerState = true;
	time(&curent_time);
	time(&init_time);
	timer=ecore_timer_add(in, func, data);
}

void Timer::pauseTimer(){
	TimerState = false;
	lapsdiffTime = difftime(curent_time,init_time);
	ecore_timer_freeze(timer);
}

void Timer::resumeTimer(){
	TimerState = true;
	init_time=time(NULL)-lapsdiffTime;
	ecore_timer_thaw(timer);
}

void Timer::continueTimer(){
	TimerState = true;
	ecore_timer_thaw(timer);
}

void Timer::resetTimer(){
	TimerState = true;
	time(&init_time);
	ecore_timer_reset(timer);

}
void Timer::stopTimer(){
	TimerState = false;
	ecore_timer_del(timer);
	timer = NULL;
}

void Timer::localCurrentTime(){
	time(&curent_time);
	time_info = localtime(&curent_time);
}

void Timer::actualiseTimer(){
	time(&curent_time);
	time_info = localtime(&curent_time);
	//diffTime = difftime(curent_time,init_time);
}

/*double Timer::getCurrentTime(){
	return diffTime;
}*/
void Timer::convertTimer(){
	double diffTime = difftime(curent_time,init_time);
	hour_timer=floor(diffTime/3600);
	min_timer=floor((diffTime-3600*GetHour())/60);
	sec_timer=floor(diffTime-3600*GetHour()-60*GetMin());
}
int Timer::GetHour(){
	return hour_timer;
}

int Timer::GetMin(){
	return min_timer;
}

int Timer::GetSec(){
	return sec_timer;
}

int Timer::GetLocalHour(){
	return time_info->tm_hour;
}

int Timer::GetLocalMin(){
	return time_info->tm_min;
}

char* Timer::GetStrLocalTime(){
	char buf[128];
	strftime(buf,128,"%R",time_info);
	return strdup(buf);
}

char* Timer::GetStrTimer(){
	double diffTime = difftime(curent_time,init_time);
	hour_timer=floor(diffTime/3600);
	min_timer=floor((diffTime-3600*GetHour())/60);
	sec_timer=floor(diffTime-3600*GetHour()-60*GetMin());

	char buf[128];
	char s[128];
	char m[128];
	char h[128];

	(sec_timer<10)? sprintf(s,"0%d",sec_timer) : sprintf(s,"%d",sec_timer);
	(min_timer<10)? sprintf(m,"0%d",(min_timer)) : sprintf(m,"%d",(min_timer));
	(hour_timer<10)? sprintf(h,"0%d",hour_timer) : sprintf(h,"%d",hour_timer);
	sprintf(buf,"%s:%s:%s",h,m,s);

	return strdup(buf);
}

bool Timer::isRunning(){
	return TimerState;
}
Timer::~Timer() {
	// TODO Auto-generated destructor stub
}

