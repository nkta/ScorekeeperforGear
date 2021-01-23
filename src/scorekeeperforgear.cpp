#include "scorekeeperforgear.h"
#include <tools_inc/Timer.h>
#include <string.h>

char *main_menu_names[] = {
	"Badminton", "Free score", "Ping-pong", "Squash", "Tennis", "Volley", "Paramètre",
	NULL
};

typedef struct _item_data
{
	int index;
	Elm_Object_Item *item;
} item_data;

#define ROTARY_SELECTOR_PAGE_COUNT 1
#define ROTARY_SELECTOR_PAGE_ITEM_COUNT 6

static void
win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
{
	ui_app_exit();
}

static void
win_back_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = (appdata_s *)data;
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}

static void
_item_selected_cb(void *data, Evas_Object *obj, void *event_info)
{
	Eext_Object_Item *item;
	const char *main_text;
	const char *sub_text;
	/* Get current selected item object */
	item = eext_rotary_selector_selected_item_get(obj);

	/* Get set text for the item */
	main_text = eext_rotary_selector_item_part_text_get(item, "selector,main_text");
	sub_text = eext_rotary_selector_item_part_text_get(item, "selector,sub_text");

	printf("Item Selected! Currently Selected %s, %s\n", main_text, sub_text);
}

static void
_item_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	Eext_Object_Item *item;
	const char *main_text;
	const char *sub_text;
	appdata_s *ad = (appdata_s *)data;

	/* Get current selected item object */
	item = eext_rotary_selector_selected_item_get(obj);

	/* Get set text for the item */
	main_text = eext_rotary_selector_item_part_text_get(item, "selector,main_text");
	sub_text = eext_rotary_selector_item_part_text_get(item, "selector,sub_text");

	ad->viewState=VIEW_SCORE_ON;
	DeviceGestion::display_mode(ad->viewState,"normal");
	if(strcmp(main_text,"Badminton") == 0){
		ad->sport_selected = new Badminton();
	}
	if(strcmp(main_text,"Free score") == 0){
		ad->sport_selected = new Football;
	}
	if(strcmp(main_text,"Ping-pong") == 0){
		ad->sport_selected = new PingPong();
	}
	if(strcmp(main_text,"Squash") == 0){
		ad->sport_selected = new Squash();
	}
	if(strcmp(main_text,"Tennis") == 0){
		ad->sport_selected = new Tennis();
	}
	if(strcmp(main_text,"Volley") == 0){
		ad->sport_selected = new Volley();
	}
	if(strcmp(main_text,"Badminton") == 0){
		ad->sport_selected = new Badminton();
	}
	//bg_blue(data);
	eext_rotary_object_event_activated_set(ad->rotary_selector, EINA_FALSE);
	viewScore_cb(data, obj, event_info);
	printf("Item Clicked!, Currently Selected %s, %s\n", main_text, sub_text);
}

void
_item_create(Evas_Object *rotary_selector,appdata_s *ad)
{
	Evas_Object *image;
	Eext_Object_Item * item;
	char buf[255] = {0};
	int i, j;

	for (i = 0; i < ROTARY_SELECTOR_PAGE_COUNT; i++)
	{
		for (j = 0; j < ROTARY_SELECTOR_PAGE_ITEM_COUNT; j++)
		{
			/* Add new eext_rotary_selector_item
				Instead of eext_rotary_selector_item_append() can be used API's
				- eext_rotary_selector_item_prepend()
				- eext_rotary_selector_item_insert_after()
				- eext_rotary_selector_item_insert_before() */
			item = eext_rotary_selector_item_append(rotary_selector);

			image = elm_image_add(rotary_selector);
			elm_image_file_set(image, icon_path_list[j % 7], NULL);

			/* Set the icon of the selector item. */
			eext_rotary_selector_item_part_content_set(item,
																	 "item,icon",
																	 EEXT_ROTARY_SELECTOR_ITEM_STATE_NORMAL,
																	 image);

			/* Set the main/sub text visible when the item is selected. */
			snprintf(buf, sizeof(buf), "%s", main_menu_names[j]);
			eext_rotary_selector_item_part_text_set(item, "selector,main_text", buf);

			eext_rotary_selector_item_part_color_set(item,"selector,sub_text",EEXT_ROTARY_SELECTOR_ITEM_STATE_NORMAL,255,255,255,255);
			//snprintf(buf, sizeof(buf), "Item : %d", j + 1);
			//eext_rotary_selector_item_part_text_set(item, "selector,sub_text", buf);
			//item = elm_genlist_item_append(rotary_selector, NULL, NULL, NULL, ELM_GENLIST_ITEM_NONE, NULL, ad);
		}
	}
}

static void
create_base_gui(appdata_s *ad)
{
	/*
		 * Widget Tree
		 * Window
		 *  - conform
		 *   - layout main
		 *    - naviframe */

		/* Window */

		Elm_Object_Item *nf_it = NULL;
		ad->STimer= new Timer;


		ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
		elm_win_conformant_set(ad->win, EINA_TRUE);
		elm_win_autodel_set(ad->win, EINA_TRUE);

		if (elm_win_wm_rotation_supported_get(ad->win)) {
			int rots[4] = { 0, 90, 180, 270 };
			elm_win_wm_rotation_available_rotations_set(ad->win, (const int *)(&rots), 4);
		}

		evas_object_smart_callback_add(ad->win, "delete,request", win_delete_request_cb, NULL);

		/* Conformant */
		ad->conform = elm_conformant_add(ad->win);
		evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		elm_win_resize_object_add(ad->win, ad->conform);
		evas_object_show(ad->conform);

		// Eext Circle Surface Creation
		ad->circle_surface = eext_circle_surface_conformant_add(ad->conform);

		/* Indicator */
		/* elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW); */

		/* Base Layout */
		/*ad->layout = elm_layout_add(ad->conform);
		evas_object_size_hint_weight_set(ad->layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		elm_layout_theme_set(ad->layout, "layout", "application", "default");
		evas_object_show(ad->layout);

		elm_object_content_set(ad->conform, ad->layout);*/

		/* Naviframe */
	    ad->nf = elm_naviframe_add(ad->conform);
	    evas_object_show(ad->nf);
	    elm_naviframe_prev_btn_auto_pushed_set(ad->nf, EINA_TRUE);
	    elm_object_content_set(ad->conform, ad->nf);
		ad->rotary_selector = eext_rotary_selector_add(ad->nf);

		/* Rotary event activated set */
		eext_rotary_object_event_activated_set(ad->rotary_selector, EINA_TRUE);

		_item_create(ad->rotary_selector,ad);

		/* Add smart callback */
		evas_object_smart_callback_add(ad->rotary_selector, "item,selected", _item_selected_cb, ad);
		evas_object_smart_callback_add(ad->rotary_selector, "item,clicked", _item_clicked_cb, ad);

		nf_it = elm_naviframe_item_push(ad->nf, _("Rotary Selector"), NULL, NULL, ad->rotary_selector, "empty");
		elm_object_part_content_set(ad->layout, "elm.swallow.content", ad->nf);
		eext_object_event_callback_add(ad->nf, EEXT_CALLBACK_BACK, win_back_cb, ad);
		eext_object_event_callback_add(ad->nf, EEXT_CALLBACK_MORE, eext_naviframe_more_cb, NULL);


		/* Show window after base gui is set up */
		evas_object_show(ad->win);

}

static bool
app_create(void *data)
{
	/* Hook to take necessary actions before main event loop starts
	   Initialize UI resources and application's data
	   If this function returns true, the main loop of application starts
	   If this function returns false, the application is terminated */
	appdata_s *ad = (appdata_s *)data;
	ad->SProcess = new SensorProcess(SENSOR_HRM);
	create_base_gui(ad);

	return true;
}

static void
app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */
}

static void
app_pause(void *data)
{
	/* Take necessary actions when application becomes invisible. */
	appdata_s *ad = (appdata_s *)data;
	DeviceGestion::display_mode(ad->viewState,"pause");
	ad->SProcess->stopSensors();
	//sensor_listener_stop(ad->SProcess->getSensorListener());
	pause_viewScore();
}

static void
app_resume(void *data)
{
	/* Take necessary actions when application becomes visible. */
	appdata_s *ad = (appdata_s *)data;
	DeviceGestion::display_mode(ad->viewState,"resume");
	ad->SProcess->startSensors();
	//sensor_listener_start(ad->SProcess->getSensorListener());
	resume_viewScore();
}

static void
app_terminate(void *data)
{
	/* Release all resources. */
	appdata_s *ad = (appdata_s *)data;
	ad->SProcess->destroySensors();
	//sensor_destroy_listener(ad->SProcess->getSensorListener());
	DeviceGestion::display_mode(ad->viewState,"terminate");
}

static void
ui_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LANGUAGE_CHANGED*/
	char *locale = NULL;
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE, &locale);
	elm_language_set(locale);
	free(locale);
	return;
}

static void
ui_app_orient_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void
ui_app_region_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void
ui_app_low_battery(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_BATTERY*/
}

static void
ui_app_low_memory(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_MEMORY*/
}

int
main(int argc, char *argv[])
{
	appdata_s ad = {0,};
	int ret = 0;

	Configuration::createConfigurationTextFile();

	ui_app_lifecycle_callback_s event_callback = {0,};
	app_event_handler_h handlers[5] = {NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);
	ui_app_remove_event_handler(handlers[APP_EVENT_LOW_MEMORY]);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "ui_app_main() is failed. err = %d", ret);
	}

	return ret;
}
