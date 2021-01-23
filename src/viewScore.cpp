/*
 * viewScore.cpp
 *
 *  Created on: May 5, 2017
 *      Author: koudota-y
 */

#include "scorekeeperforgear.h"

#include <sensor.h>


typedef struct lappdata {
	Evas_Object* box;
	Evas_Object* grid;
	Evas_Object* labelMe;
	Evas_Object* labelOpponent;
	Evas_Object* labelpoint1;
	Evas_Object* labelpoint2;
	Evas_Object* buttonScoreMe;
	Evas_Object* buttonScoreOppennent;
	Evas_Object* labelmanche1;
	Evas_Object* labelmanche2;
	Evas_Object* labelTime;
	Evas_Object* labelHRM;
	Evas_Object* labelSetWin;
	Evas_Object* labelBattery;
	Evas_Object* button;
	Evas_Object* bg;
	Evas_Object* buttonReset;
	Evas_Object* buttonReset2;
	Ecore_Timer* timer;
	Ecore_Timer* timerchange;
	Timer* timerScore;
	Evas_Object* labelClock;
	Evas_Object* more_option;
} lappdata_s;

lappdata_s lad= {0,};

appdata_s *ad2;

static const int ITEM_COUNT_MAX = 5;
int count=0;
int laps=0;
int lock_rotation=0;
int lockscore=0;
int old_sens;
//time_t init_time;
time_t init_time_change;

SensorProcess *SProcess;

sport *sport_selected;
Timer *STimer;

bool pause_state;
bool reset_in_pause_state;

//char olda[100];
void
_reset_clicked_cb()
{
	char tmp[128];
	sport_selected->reset_score();
	sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=100>%s</font/>", sport_selected->get_str_user_score());
	elm_object_text_set(lad.buttonScoreMe, tmp);
	sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=100>%s</font/>", sport_selected->get_str_opponent_score());
	elm_object_text_set(lad.buttonScoreOppennent, tmp);
	elm_object_text_set(lad.labelTime, "<align=center><font=Tizen:style=Regular font_size=40>00:00:00</font/>");
	sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=35>%s</font/>", sport_selected->get_str_user_set());
	elm_object_text_set(lad.labelmanche1, tmp);
	sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=35>%s</font/>", sport_selected->get_str_opponent_set());
	elm_object_text_set(lad.labelmanche2, tmp);
	sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=35>%s</font/>", sport_selected->get_str_user_point());
	elm_object_text_set(lad.labelpoint1, tmp);
	sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=35>%s</font/>", sport_selected->get_str_opponent_point());
	elm_object_text_set(lad.labelpoint2, tmp);
	STimer->resetTimer();
	//ecore_timer_del(lad.timer);
	//lad.timer = NULL;
	//lad.timer=ecore_timer_add(0.1, _progressbar_timer_cb_1, &lad);

}

static Eina_Bool
_reset_counter(void *data)
{
	lad.timerScore->actualiseTimer();
	lad.timerScore->convertTimer();
	laps = lad.timerScore->GetSec();
	if(laps==2){
		lockscore=0;
		count=0;
		lad.timerScore->stopTimer();
		/*ecore_timer_del (lad.timerchange);
		lad.timerchange=NULL;*/
	}
	return ECORE_CALLBACK_RENEW;

}

Eina_Bool
_rotary_event_cb(void *data, Eext_Rotary_Event_Info *ev)
{
	//Evas_Object *label = obj;
	appdata_s *ad= (appdata_s *)data;
	if(!lad.timerScore->isRunning()){
		//init_time_change=time(NULL);
		lad.timerScore->startTimer(0.1, _reset_counter, NULL);
	}
	char tmp[128];
	char* a;
	char* b;
	char* c;
	char* d;
	char* e;


	if(lock_rotation==0 && lockscore==0){
		if (ev->direction != old_sens) {
			old_sens=ev->direction;
			count=0;
		}
		if(count==2){
			count=0;
			lockscore=1;
			if (ev->direction == EEXT_ROTARY_DIRECTION_CLOCKWISE) {
				sport_selected->count_score(1);
				a=sport_selected->get_str_user_score();
				b=sport_selected->get_str_opponent_score();
				c=sport_selected->get_str_opponent_set();
				d=sport_selected->get_str_opponent_point();
				e=sport_selected->get_str_user_point();
				DeviceGestion::device_vibrate(200, 100);
				sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=35>%s</font/>", c/*ad->sport_selected->get_user_set()*/);
				elm_object_text_set(lad.labelmanche2, tmp);
				sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=35>%s</font/>", e/*ad->sport_selected->get_user_set()*/);
				elm_object_text_set(lad.labelpoint1, tmp);
				sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=35>%s</font/>", d/*ad->sport_selected->get_user_set()*/);
				elm_object_text_set(lad.labelpoint2, tmp);
				sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=100><color=#FF4500FF>%s</color></font/>", b/*ad->sport_selected->get_user_score()*/);
				elm_object_text_set(lad.buttonScoreOppennent, tmp);
				sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=100><color=#FFFFFFFF>%s</color></font/>", a/*ad->sport_selected->get_opponent_score()*/);
				elm_object_text_set(lad.buttonScoreMe, tmp);
			} else {
				sport_selected->count_score(0);
				a=sport_selected->get_str_opponent_score();
				b=sport_selected->get_str_user_score();
				c=sport_selected->get_str_user_set();
				d=sport_selected->get_str_user_point();
				e=sport_selected->get_str_opponent_point();
				DeviceGestion::device_vibrate(200, 100);
				sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=35>%s</font/>", c/*ad->sport_selected->get_user_set()*/);
				elm_object_text_set(lad.labelmanche1, tmp);
				sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=35>%s</font/>", e/*ad->sport_selected->get_user_set()*/);
				elm_object_text_set(lad.labelpoint1, tmp);
				sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=35>%s</font/>", d/*ad->sport_selected->get_user_set()*/);
				elm_object_text_set(lad.labelpoint2, tmp);
				sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=100><color=#FF4500FF>%s</color></font/>", b/*ad->sport_selected->get_user_score()*/);
				elm_object_text_set(lad.buttonScoreMe, tmp);
				sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=100><color=#FFFFFFFF>%s</color></font/>", a/*ad->sport_selected->get_opponent_score()*/);
				elm_object_text_set(lad.buttonScoreOppennent, tmp);
			}
			if( ad2->sport_selected->get_isWinUser() || ad2->sport_selected->get_isWinOpponent() ){
				DeviceGestion::device_vibrate(3000, 100);
				bg_blue(ad2);
			}
		}
	count++;
	}

    return EINA_FALSE;
}

static Eina_Bool
_progressbar_timer_cb_1(void *data)
{
	int battery_percent;
	STimer->actualiseTimer();

	char bat[128];
	if(STimer->GetSec()%50==0){
		device_battery_get_percent(&battery_percent);
		sprintf(bat,"<align=center><font=Tizen:style=Regular font_size=30>%d</font/>",battery_percent);
		elm_object_text_set(lad.labelBattery,bat);
	}

	char buf[100];
	std::vector<int> sensorRes= SProcess->getSensorValue();
	sprintf(buf,"<align=center><font=Tizen:style=Regular font_size=30>%d</font/>", sensorRes[0]);
	elm_object_text_set(lad.labelHRM, buf);

	char a[100];
	sprintf(a,"<align=center><font=Tizen:style=Regular font_size=30>%d</font/>", ad2->sport_selected->get_setWinNbr());
	elm_object_text_set(lad.labelSetWin, a);

	char tmp2[128];
	sprintf (tmp2, "<align=center><font=Tizen:style=Regular font_size=40>%s</font/>",STimer->GetStrTimer());
	elm_object_text_set(lad.labelTime, tmp2);

	char tmp3[128];
	sprintf (tmp3, "<align=center><font=Tizen:style=Regular font_size=40>%s</font/>",STimer->GetStrLocalTime());
	elm_object_text_set(lad.labelClock, tmp3);
	return ECORE_CALLBACK_RENEW;
}



void pause_viewScore(){
	lock_rotation = 1;
}
void resume_viewScore(){
	lock_rotation = 0;
}


static void
_creat_page(Evas_Object *parent, int index)
{
	Evas_Object *img = NULL;

	/* Create the new item */
	Eext_Object_Item *item  = eext_more_option_item_append(parent);
	printf("item is created!!! [%p]\n", item);

	/* Set the content in item */
	if (index == 0) {
		/* Set the text in item text part */
		if(!pause_state){
			eext_more_option_item_part_text_set(item, "selector,main_text", "Pause");

			img = elm_image_add(parent);
			/* Set the content in item content part */
			eext_more_option_item_part_content_set(item, "item,icon", img);
			elm_image_file_set(img, ICON_DIR"/pause_icon.png", NULL);
		}else{
			eext_more_option_item_part_text_set(item, "selector,main_text", "Play");

			img = elm_image_add(parent);
			/* Set the content in item content part */
			eext_more_option_item_part_content_set(item, "item,icon", img);
			elm_image_file_set(img, ICON_DIR"/icon_play.png", NULL);
		}

	} else if (index == 1) {
		eext_more_option_item_part_text_set(item, "selector,main_text", "Reset");

		img = elm_image_add(parent);
		eext_more_option_item_part_content_set(item, "item,icon", img);
		elm_image_file_set(img, ICON_DIR"/reset_icon.png", NULL);
	} else if (index == 2) {
		eext_more_option_item_part_text_set(item, "selector,main_text", "Settings");

		img = elm_image_add(parent);
		eext_more_option_item_part_content_set(item, "item,icon", img);
		elm_image_file_set(img, ICON_DIR"/roue_cranter.png", NULL);
	} else if (index == 3) {
				eext_more_option_item_part_text_set(item, "selector,main_text", "Home");

				img = elm_image_add(parent);
				eext_more_option_item_part_content_set(item, "item,icon", img);
				elm_image_file_set(img, ICON_DIR"/Maison.png", NULL);
	} else if (index == 4) {
		eext_more_option_item_part_text_set(item, "selector,main_text", "Return");

		img = elm_image_add(parent);
		eext_more_option_item_part_content_set(item, "item,icon", img);
		elm_image_file_set(img, ICON_DIR"/return-icon.png", NULL);
	}
	return;
}

static void
_more_option_opened(void *data, Evas_Object *obj, void *event_info)
{
	lock_rotation = 1;
	STimer->pauseTimer();
	printf("more option is opened!!! \n");
}

static void
_more_option_closed(void *data, Evas_Object *obj, void *event_info)
{
	lock_rotation = 0;
	printf("more option is closed!!! \n");
}

static void
_item_selected(void *data, Evas_Object *obj, void *event_info)
{
	Eext_Object_Item *item = (Eext_Object_Item *)event_info;

	const char *main_text;
	const char *sub_text;
	/* Get the text in item text part */
	main_text = eext_more_option_item_part_text_get(item, "selector,main_text");
	sub_text = eext_more_option_item_part_text_get(item, "selector,sub_text");
	printf("item[%p]:main text[%s](sub text[%s]) is selected!\n", item, main_text, sub_text);
}

void
_clicked_buttonScoreMe(void *data, Evas_Object *obj, void *event_info)
{
	char tmp[128];
	char* a;
	char* b;
	char* c;
	char* d;
	char* e;
	sport_selected->count_score(0);
	a=sport_selected->get_str_opponent_score();
	b=sport_selected->get_str_user_score();
	c=sport_selected->get_str_user_set();
	d=sport_selected->get_str_user_point();
	e=sport_selected->get_str_opponent_point();
	sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=35>%s</font/>", c/*ad->sport_selected->get_user_set()*/);
	elm_object_text_set(lad.labelmanche1, tmp);
	sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=35>%s</font/>", e/*ad->sport_selected->get_user_set()*/);
	elm_object_text_set(lad.labelpoint1, tmp);
	sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=35>%s</font/>", d/*ad->sport_selected->get_user_set()*/);
	elm_object_text_set(lad.labelpoint2, tmp);
	sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=100><color=#FF4500FF>%s</color></font/>", b/*ad->sport_selected->get_user_score()*/);
	elm_object_text_set(lad.buttonScoreMe, tmp);
	sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=100><color=#FFFFFFFF>%s</color></font/>", a/*ad->sport_selected->get_opponent_score()*/);
	elm_object_text_set(lad.buttonScoreOppennent, tmp);
	if( ad2->sport_selected->get_isWinUser() || ad2->sport_selected->get_isWinOpponent() ){
		DeviceGestion::device_vibrate(3000, 100);
		bg_blue(ad2);
	}
}

void
_clicked_buttonScoreOppennent(void *data, Evas_Object *obj, void *event_info)
{
	char tmp[128];
	char* a;
	char* b;
	char* c;
	char* d;
	char* e;
	sport_selected->count_score(1);
	a=sport_selected->get_str_user_score();
	b=sport_selected->get_str_opponent_score();
	c=sport_selected->get_str_opponent_set();
	d=sport_selected->get_str_opponent_point();
	e=sport_selected->get_str_user_point();
	sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=35>%s</font/>", c/*ad->sport_selected->get_user_set()*/);
	elm_object_text_set(lad.labelmanche2, tmp);
	sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=35>%s</font/>", e/*ad->sport_selected->get_user_set()*/);
	elm_object_text_set(lad.labelpoint1, tmp);
	sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=35>%s</font/>", d/*ad->sport_selected->get_user_set()*/);
	elm_object_text_set(lad.labelpoint2, tmp);
	sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=100><color=#FF4500FF>%s</color></font/>", b/*ad->sport_selected->get_user_score()*/);
	elm_object_text_set(lad.buttonScoreOppennent, tmp);
	sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=100><color=#FFFFFFFF>%s</color></font/>", a/*ad->sport_selected->get_opponent_score()*/);
	elm_object_text_set(lad.buttonScoreMe, tmp);
	if( ad2->sport_selected->get_isWinUser() || ad2->sport_selected->get_isWinOpponent() ){
		DeviceGestion::device_vibrate(3000, 100);
		bg_blue(ad2);
	}
}


static void
_item_clicked(void *data, Evas_Object *obj, void *event_info)
{
	Eext_Object_Item *item = (Eext_Object_Item *)event_info;

	const char *main_text;
	const char *sub_text;


	main_text = eext_more_option_item_part_text_get(item, "selector,main_text");
	sub_text = eext_more_option_item_part_text_get(item, "selector,sub_text");
	printf("item[%p]:main text[%s](sub text[%s]) is selected!\n", item, main_text, sub_text);

	if(strcmp(main_text,"Pause") == 0){
		pause_state = true;
		pause_viewScore();
		eext_more_option_items_clear (lad.more_option);
		for (int i = 0; i < ITEM_COUNT_MAX; ++i) {
			if (i == 0)
				_creat_page(lad.more_option, i);
			else
				_creat_page(lad.more_option, i);
		}
	}
	if(strcmp(main_text,"Play") == 0){
		pause_state = false;
		resume_viewScore();
		eext_more_option_items_clear (lad.more_option);
		for (int i = 0; i < ITEM_COUNT_MAX; ++i) {
			if (i == 0)
				_creat_page(lad.more_option, i);
			else
				_creat_page(lad.more_option, i);
		}
		if(!reset_in_pause_state){
			STimer->resumeTimer();
		}else{
			STimer->continueTimer();
			_reset_clicked_cb();
			reset_in_pause_state=false;
		}
	}
	if(strcmp(main_text,"Reset") == 0){
		_reset_clicked_cb();
		if(!pause_state){
			STimer->continueTimer();
		}else {
			reset_in_pause_state=true;
		}
	}

	if(strcmp(main_text,"Settings") == 0){
		_default_cb(ad2);
		if(!pause_state)
			STimer->continueTimer();
	}

	if(strcmp(main_text,"Home") == 0){
		ad2->SProcess->stopSensors();
		eext_rotary_object_event_activated_set(ad2->rotary_selector, EINA_TRUE);
		eext_rotary_event_handler_del(_rotary_event_cb);
		elm_naviframe_item_pop(ad2->nf);
	}

	if(strcmp(main_text,"Return") == 0){
		//bg_blue(ad2);
		if(!pause_state)
			STimer->continueTimer();
	}
	eext_more_option_opened_set	(lad.more_option,EINA_FALSE);

}

void
viewScore_cb(void *data, Evas_Object *obj, void *event_info)
{
	lad.timerchange = NULL;

	appdata_s *ad = (appdata_s *)data;
	ad2 = (appdata_s *)data;
	Evas_Object *nf = ad->nf;
	sport_selected = ad->sport_selected;
	STimer = ad->STimer;
	STimer->startTimer(0.1, _progressbar_timer_cb_1, &lad);

	lad.timerScore = new Timer;

	SProcess = ad->SProcess;
	SProcess->startSensors();

    lad.bg = elm_bg_add(nf);

    pause_state = false;
    reset_in_pause_state=false;
    //elm_bg_color_set(bg, 64, 127, 256);
    elm_bg_file_set(lad.bg,"/opt/usr/apps/org.example.scorekeeperforgear/res/image/bg2.png",NULL);
    elm_bg_option_set(lad.bg,ELM_BG_OPTION_CENTER);
    elm_naviframe_item_push(nf, NULL, NULL, NULL, lad.bg, "empty");

    lad.grid = elm_grid_add(lad.bg);
    	    elm_object_content_set(lad.bg, lad.grid);
    	    //evas_object_show(lad.grid);

    	    char tmp[128];

    	    lad.labelMe = elm_label_add(lad.grid);
    	    elm_object_text_set(lad.labelMe,"<align=center><font=Tizen:style=Regular font_size=30>Me</font/>");
    	    elm_grid_pack(lad.grid, lad.labelMe, 0, 29, 50, 50);
    	    evas_object_show(lad.labelMe);

    	    lad.labelOpponent = elm_label_add(lad.grid);
    	    elm_object_text_set(lad.labelOpponent, "<align=center><font=Tizen:style=Regular font_size=30>Opponent</font/>");
    	    elm_grid_pack(lad.grid, lad.labelOpponent, 47, 29, 50, 50);
    	    evas_object_show(lad.labelOpponent);

    	    lad.labelpoint1 = elm_label_add(lad.grid);
    	    sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=35>%s</font/>", sport_selected->get_str_user_point());
    	    elm_object_text_set(lad.labelpoint1, tmp);
    	    elm_grid_pack(lad.grid, lad.labelpoint1, 8, 55, 50, 50);
    	    evas_object_show(lad.labelpoint1);

    	    lad.labelpoint2 = elm_label_add(lad.grid);
    	    sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=35>%s</font/>", sport_selected->get_str_opponent_point());
    	    elm_object_text_set(lad.labelpoint2, tmp);
    	    elm_grid_pack(lad.grid, lad.labelpoint2, 41, 55, 50, 50);
    	    evas_object_show(lad.labelpoint2);

    	    lad.labelmanche1 = elm_label_add(lad.grid);
    	    sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=35>%s</font/>", sport_selected->get_str_user_set());
    	    elm_object_text_set(lad.labelmanche1, tmp);
    	    elm_grid_pack(lad.grid, lad.labelmanche1, 19, 55, 50, 50);
    	    evas_object_show(lad.labelmanche1);

    	    lad.labelmanche2 = elm_label_add(lad.grid);
    	    sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=35>%s</font/>", sport_selected->get_str_opponent_set());
    	    elm_object_text_set(lad.labelmanche2, tmp);
    	    elm_grid_pack(lad.grid, lad.labelmanche2, 31, 55, 50, 50);
    	    evas_object_show(lad.labelmanche2);

    	    lad.labelTime = elm_label_add(lad.grid);
    	    elm_object_text_set(lad.labelTime, "<align=center><font=Tizen:style=Regular font_size=40>00:00:00</font/>");
    	    elm_grid_pack(lad.grid, lad.labelTime, 25, 65, 50, 50);
    	    evas_object_show(lad.labelTime);

    	    lad.labelClock = elm_label_add(lad.grid);
    	    elm_object_text_set(lad.labelClock, "<align=center><font=Tizen:style=Regular font_size=40>00:00</font/>");
    	    elm_grid_pack(lad.grid, lad.labelClock, 25, 18, 50, 50);
    	    evas_object_show(lad.labelClock);

    	    lad.labelHRM = elm_label_add(lad.grid);
    	    elm_object_text_set(lad.labelHRM, "<align=center><font=Tizen:style=Regular font_size=30>0</font/>");
    	    elm_grid_pack(lad.grid, lad.labelHRM, -5, 68, 50, 50);
    	    evas_object_show(lad.labelHRM);

    	    lad.labelSetWin = elm_label_add(lad.grid);
    	    elm_object_text_set(lad.labelSetWin, "<align=center><font=Tizen:style=Regular font_size=30>0</font/>");
    	    elm_grid_pack(lad.grid, lad.labelSetWin, -5, 18, 50, 50);
    	    evas_object_show(lad.labelSetWin);

    	    lad.labelBattery = elm_label_add(lad.grid);
    	    elm_object_text_set(lad.labelBattery, "<align=center><font=Tizen:style=Regular font_size=30>0</font/>");
    	    elm_grid_pack(lad.grid, lad.labelBattery, 55, 68, 50, 50);
    	    evas_object_show(lad.labelBattery);

    	    elm_theme_extension_add(NULL, "/opt/usr/apps/org.example.scorekeeperforgear/res/edje/Trans_button.edj");

    	    lad.buttonScoreMe = elm_button_add(lad.grid);
    	    //elm_bg_color_set(lad.buttonpoint1, 0, 25, 0);
    	    elm_object_style_set(lad.buttonScoreMe, "customized");
    	    sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=100>%s</font/>", sport_selected->get_str_user_score());
    	    elm_object_text_set(lad.buttonScoreMe, tmp);
    	    elm_grid_pack(lad.grid, lad.buttonScoreMe, -10, 25, 50, 50);
    	    evas_object_show(lad.buttonScoreMe);

    	    lad.buttonScoreOppennent = elm_button_add(lad.grid);
    	    elm_object_style_set(lad.buttonScoreOppennent, "customized");
    	    sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=100>%s</font/>", sport_selected->get_str_opponent_score());
    	    elm_object_text_set(lad.buttonScoreOppennent, tmp);
    	    elm_bg_file_set(lad.buttonScoreOppennent,"/opt/usr/apps/org.example.scorekeeperforgear/res/image/transparent.png",NULL);
    	    elm_grid_pack(lad.grid, lad.buttonScoreOppennent, 60, 25, 50, 50);
    	    evas_object_show(lad.buttonScoreOppennent);

    		lad.more_option = eext_more_option_add(lad.bg);
    		eext_more_option_direction_set(lad.more_option, EEXT_MORE_OPTION_DIRECTION_BOTTOM);
    		elm_grid_pack(lad.grid, lad.more_option, 45, 46, 10, 10);
    		for (int i = 0; i < ITEM_COUNT_MAX; ++i) {
    			if (i == 0)
    				_creat_page(lad.more_option, i);
    			else
    				_creat_page(lad.more_option, i);
    		}

    		/* Add smart callback */
    		evas_object_smart_callback_add(lad.more_option, "more,option,opened", _more_option_opened, NULL);
    		evas_object_smart_callback_add(lad.more_option, "more,option,closed", _more_option_closed, NULL);
    		evas_object_smart_callback_add(lad.more_option, "item,selected", _item_selected, NULL);
    		evas_object_smart_callback_add(lad.more_option, "item,clicked", _item_clicked, NULL);
    		evas_object_smart_callback_add(lad.buttonScoreMe, "clicked", _clicked_buttonScoreMe, NULL);
    		evas_object_smart_callback_add(lad.buttonScoreOppennent, "clicked", _clicked_buttonScoreOppennent, NULL);
    		/* Push the More option as Naviframe item */
    		//elm_naviframe_item_push(lad., "More Option Demo", NULL, NULL, lad.more_option, "empty");

    	    eext_rotary_event_handler_add(_rotary_event_cb, NULL);

}


