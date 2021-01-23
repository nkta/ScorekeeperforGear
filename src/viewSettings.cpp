#include "scorekeeperforgear.h"

Evas_Object *focused_obj = NULL;
Evas_Object *unit;


static void
_btn_clicked_restart(void *data, Evas_Object *obj, void *event_info)
{
   appdata_s *ad = (appdata_s *)data;
   ad->SProcess->startSensors();
   ad->lock_rotation = 0;
   _reset_clicked_cb();
   eext_rotary_event_handler_add(_rotary_event_cb,NULL);
   elm_naviframe_item_pop(ad->nf);
}


void bg_blue(void *data){
	DeviceGestion::display_mode(true,"terminate");
	appdata_s *ad= (appdata_s *)data;
	Evas_Object *bg2;
	Evas_Object *labelScoreOppennent;
	Evas_Object *grid;
	Evas_Object *labelScoreMe;
	Evas_Object *labelMe;
	Evas_Object *labelTime;
	Evas_Object *bottom_button;
	Evas_Object *layout;

	ad->SProcess->stopSensors();
	ad->lock_rotation = 1;
	eext_rotary_event_handler_del(_rotary_event_cb);
	bg2 = elm_bg_add(ad->nf);
	//elm_bg_color_set(bg2, 64, 127, 256);
	elm_bg_option_set(bg2,ELM_BG_OPTION_CENTER);
	elm_naviframe_item_push(ad->nf, NULL, NULL, NULL, bg2, "empty");
	evas_object_show(bg2);


	grid = elm_grid_add(bg2);
	elm_object_content_set(bg2, grid);
	evas_object_show(grid);



	char tmp[128];
	labelScoreMe = elm_label_add(grid);
	sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=40>%s</font/>", ad->sport_selected->get_str_tabScoreUser());
	elm_object_text_set(labelScoreMe, tmp);
	elm_grid_pack(grid, labelScoreMe, 0, 50, 100, 100);
	evas_object_show(labelScoreMe);

	labelScoreOppennent = elm_label_add(grid);
	sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=40>%s</font/>", ad->sport_selected->get_str_tabScoreOpponent());
	elm_object_text_set(labelScoreOppennent, tmp);
	elm_grid_pack(grid, labelScoreOppennent, 0, 60, 100, 100);
	evas_object_show(labelScoreOppennent);

	labelTime = elm_label_add(grid);
	sprintf (tmp, "<align=center><font=Tizen:style=Regular font_size=40>%s</font/>", ad->STimer->GetStrTimer());
	elm_object_text_set(labelTime, tmp);
	elm_grid_pack(grid, labelTime, 0, 40, 100, 100);
	evas_object_show(labelTime);

	labelMe = elm_label_add(grid);
	if(ad->sport_selected->get_isWinUser()){
		elm_object_text_set(labelMe,"<align=center><font=Tizen:style=Regular font_size=50>You win</font/>");
	}else{
		elm_object_text_set(labelMe,"<align=center><font=Tizen:style=Regular font_size=50>You lose</font/>");
	}
	elm_grid_pack(grid, labelMe, 20, 25, 60, 60);
	evas_object_show(labelMe);

	/*bottom_button = elm_button_add(layout);
		elm_object_style_set(bottom_button, "bottom");
		elm_object_text_set(bottom_button, "Restart");
		evas_object_smart_callback_add(bottom_button, "clicked", _btn_clicked_restart, ad);
		elm_object_part_content_set(layout, "elm.swallow.btn", bottom_button);
		evas_object_show(bottom_button);*/

	bottom_button = elm_button_add(grid);
	elm_object_style_set(bottom_button, "bottom");
	elm_object_text_set(bottom_button, "Reset");
	elm_object_part_content_set(grid, "elm.swallow.button", bottom_button);
	elm_grid_pack(grid, bottom_button, 45, 85, 10, 10);
	evas_object_smart_callback_add(bottom_button, "clicked", _btn_clicked_restart, ad);
	evas_object_show(bottom_button);
	//evas_object_show(layout);

}

static void _focused_cb(void *data, Evas_Object *obj, void *event_info)
{
   focused_obj = obj;
   eext_rotary_object_event_activated_set(obj, EINA_TRUE);
}

static Eina_Bool
_spinner_naviframe_pop_cb(void *data, Elm_Object_Item *it)
{
   eext_rotary_object_event_activated_set(focused_obj, EINA_FALSE);

   return EINA_TRUE;
}

static void
_btn_clicked(void *data, Evas_Object *obj, void *event_info)
{
   appdata_s *ad = (appdata_s *)data;
   ad->sport_selected->set_setWinNbr(elm_spinner_value_get(unit));
   ad->lock_rotation = 0;
   eext_rotary_event_handler_add(_rotary_event_cb,NULL);
   Configuration::writeConfig(ad->sport_selected->get_nameSport(),elm_spinner_value_get(unit));
   elm_naviframe_item_pop(ad->nf);
}


void _default_cb(void *data)
{
   appdata_s *ad = (appdata_s *)data;
   Evas_Object *layout, *bottom_button, *circle_spinner;
   Elm_Object_Item *nf_it;

   eext_rotary_event_handler_del(_rotary_event_cb);
   layout = elm_layout_add(ad->nf);
   elm_layout_theme_set(layout, "layout", "circle", "spinner");

   evas_object_show(layout);
   ad->lock_rotation = 1;
   unit = elm_spinner_add(layout);
   elm_object_style_set(unit,"circle");
   //Circle spinner add for circular visual interaction with rotary event.
   circle_spinner = eext_circle_object_spinner_add(unit, ad->circle_surface);
   //This angle per each spinner value will be multiplied with step value
   //and set the circle spinner picker offset, when every rotary event called.
   eext_circle_object_spinner_angle_set(circle_spinner, 90.0);
   evas_object_show(unit);

   elm_spinner_wrap_set(unit, EINA_FALSE);
  // elm_spinner_label_format_set(unit, "%1.1f");
   elm_spinner_label_format_set(unit, "%d");
   elm_spinner_min_max_set(unit, 1, 5);
   //The circle spinner picker move angle will be calculated below formula
   //{360/(99(Spinner max)-9(Spinner min)) * 2.0(Circle spinner angle) * 7.5(Spinner step)}
   elm_spinner_step_set(unit, 1);
   elm_spinner_value_set(unit,ad->sport_selected->get_setWinNbr());
   elm_object_part_text_set(unit, "elm.text", "unit");
   evas_object_smart_callback_add(unit, "focused", _focused_cb, unit);
   elm_object_part_content_set(layout, "elm.swallow.content", unit);

   bottom_button = elm_button_add(layout);
   elm_object_style_set(bottom_button, "bottom");
   elm_object_text_set(bottom_button, "SET");
   evas_object_smart_callback_add(bottom_button, "clicked", _btn_clicked, ad);
   elm_object_part_content_set(layout, "elm.swallow.btn", bottom_button);

   elm_object_part_text_set(layout, "elm.text", "Set win");
   nf_it = elm_naviframe_item_push(ad->nf, _("Spinner"), NULL, NULL, layout, NULL);
   elm_naviframe_item_title_enabled_set(nf_it, EINA_FALSE, EINA_FALSE);
   elm_naviframe_item_pop_cb_set(nf_it, _spinner_naviframe_pop_cb, NULL);
}
