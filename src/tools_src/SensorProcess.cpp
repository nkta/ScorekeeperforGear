/*
 * SensorProcess.cpp
 *
 *  Created on: May 4, 2017
 *      Author: koudota-y
 */

#include "tools_inc\SensorProcess.h"
#include <stdio.h>


SensorProcess::SensorProcess(sensor_type_e sensorType) {
	int error;
	Sres.sensorType=sensorType;


	sensor_get_default_sensor(Sres.sensorType, &sensor);
	sensor_create_listener(sensor, &listener);
	error = sensor_listener_set_event_cb(listener, 100, SensorProcess::on_sensor_event, &Sres);
	if (error != SENSOR_ERROR_NONE) {
		Sres.sensorValue.push_back(30);
	}
}

void SensorProcess::on_sensor_event(sensor_h sensor, sensor_event_s *event, void *user_data){
	sensor_result_t* Sres=(sensor_result_t*)user_data;
    // Select a specific sensor with a sensor handle
    sensor_type_e type;
    Sres->sensorValue.clear();
    switch (Sres->sensorType) {
		case SENSOR_HRM:
			Sres->sensorValue.push_back(event->values[0]);
			break;
		case SENSOR_ACCELEROMETER:
		case SENSOR_GRAVITY:
		case SENSOR_LINEAR_ACCELERATION:
		case SENSOR_GYROSCOPE:
			Sres->sensorValue.push_back(event->values[0]);
			Sres->sensorValue.push_back(event->values[1]);
			Sres->sensorValue.push_back(event->values[2]);
			break;
		//case SENSOR_HUMAN_PEDOMETER:
			//char a[100];
			//sprintf(a,"<align=center><font=Tizen:style=Regular font_size=30>%d</font/>", (int)event->values[0]);
			//break;
    }
}

std::vector<int> SensorProcess::getSensorValue(){
	return Sres.sensorValue;
}

void SensorProcess::startSensors(){
		sensor_listener_start(listener);
}

void SensorProcess::stopSensors(){
		sensor_listener_stop(listener);
}

void SensorProcess::destroySensors(){
		sensor_destroy_listener(listener);
}

SensorProcess::~SensorProcess(){
}
