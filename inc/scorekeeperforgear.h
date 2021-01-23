#ifndef __scorekeeperforgear_H__
#define __scorekeeperforgear_H__


#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>
#include <sport_inc/header_sport.hpp>
#include <tools_inc/Timer.h>
#include <tools_inc/DeviceGestion.h>
#include <tools_inc/SensorProcess.h>
#include <vector>
#include <device/haptic.h>
#include <device/battery.h>
#include <tizen.h>
#include <device/power.h>
#include <time.h>
#include <math.h>


#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "scorekeeperforgear"

#if !defined(PACKAGE)
#define PACKAGE "org.example.scorekeeperforgear"
#endif

#define EDJ_FILE "edje/scorekeeperforgear.edj"
#define GRP_MAIN "main"
#define ICON_DIR "/opt/usr/apps/org.example.scorekeeperforgear/res/images"

static char *icon_path_list[] = {
	ICON_DIR"/badminton-40740_640.png",
	ICON_DIR"/futsal-40765_640.png",
	ICON_DIR"/table-40793_640.png",
	ICON_DIR"/squash-40790_640.png",
	ICON_DIR"/tennis-40795_640.png",
	ICON_DIR"/volley-40799_640.png",
	ICON_DIR"/roue_cranter.png",
	NULL
};

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *layout;
	Evas_Object *nf;
	Evas_Object *datetime;
	Evas_Object *popup;
	Evas_Object *button;
	Eext_Circle_Surface *circle_surface;
	Evas_Object *rotary_selector;
	struct tm saved_time;
	sport* sport_selected;
	Timer* STimer;
	//sensor_result_t Sres;
	SensorProcess *SProcess;
	int select_number_sport;
	bool viewState;
	int lock_rotation;
} appdata_s;


#endif /* __scorekeeperforgear_H__ */

struct _menu_item {
   char *name;
   void (*func)(void *data, Evas_Object *obj, void *event_info);
};


void bg_cb(void *data, Evas_Object * obj, void *event_info);
void viewScore_cb(void *data, Evas_Object *obj, void *event_info);
void pause_viewScore();
void resume_viewScore();
void bg_blue(void *data);
void _default_cb(void *data);
Eina_Bool _rotary_event_cb(void *data, Eext_Rotary_Event_Info *ev);
void _reset_clicked_cb();

