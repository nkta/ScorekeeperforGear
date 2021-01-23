/*
 * DeviceGestion.cpp
 *
 *  Created on: May 13, 2017
 *      Author: nicolas
 */

#include <tools_inc/DeviceGestion.h>
#include "string.h"

void DeviceGestion::device_vibrate(int duration, int feedback) {
	haptic_device_h haptic_handle;
	haptic_effect_h effect_handle;

	if(device_haptic_open(0, &haptic_handle) == DEVICE_ERROR_NONE) {

		//LOGI("Connection to vibrator established");

		if(device_haptic_vibrate(haptic_handle, duration, feedback, &effect_handle) == DEVICE_ERROR_NONE) {
			//LOGI("Device vibrates!");
		}

//		To stop vibration which are being played use below code with proper handles
//		if(device_haptic_stop(haptic_handle, effect_handle) == DEVICE_ERROR_NONE) {
//			LOGI("Device vibration stopped");
//		}

//		When you decided not to use haptic anymore disconnect it
//		if(device_haptic_close(haptic_handle) == DEVICE_ERROR_NONE) {
//			LOGI("Vibrator disconnected");
//		}
	}
}

void DeviceGestion::display_mode(bool viewState,char* state ){

	if(strcmp(state,"normal") == 0){
		if(viewState){
			device_power_request_lock(POWER_LOCK_DISPLAY,0);
		}else if (viewState) {
			device_power_release_lock(POWER_LOCK_DISPLAY);
		}
	}
	if(strcmp(state,"pause") == 0 || strcmp(state,"terminate") == 0){
		if(viewState){
			device_power_release_lock(POWER_LOCK_DISPLAY);
		}
	}
	if(strcmp(state,"resume") == 0){
		if(viewState){
			device_power_request_lock(POWER_LOCK_DISPLAY,0);
		}
	}
}
