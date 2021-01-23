/*
 * DeviceGestion.h
 *
 *  Created on: May 13, 2017
 *      Author: nicolas
 */

#ifndef TOOLS_INC_DEVICEGESTION_H_
#define TOOLS_INC_DEVICEGESTION_H_

#include <device/haptic.h>
#include <device/battery.h>
#include <tizen.h>
#include <device/power.h>

#define VIEW_SCORE_ON true
#define VIEW_SCORE_OFF false

class DeviceGestion {
public:
	static void device_vibrate(int duration, int feedback);
	static void display_mode(bool viewState,char* state  );
};

#endif /* TOOLS_INC_DEVICEGESTION_H_ */
