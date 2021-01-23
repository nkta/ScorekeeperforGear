/*
 * SensorProcess.h
 *
 *  Created on: May 4, 2017
 *      Author: koudota-y
 */

#ifndef TOOLS_SRC_SENSORPROCESS_H_
#define TOOLS_SRC_SENSORPROCESS_H_

#include <sensor.h>
#include <vector>

#define VIEW_SCORE_WITH_ARM_TRACKING 5
#define VIEW_SCORE_WITHOUT_ARM_TRACKING 1


class SensorProcess {
public:
	SensorProcess(sensor_type_e sensorType);
	void startSensors();
	void stopSensors();
	void destroySensors();
	std::vector<int> getSensorValue();
	virtual ~SensorProcess();

private:
	static void on_sensor_event(sensor_h sensor, sensor_event_s *event, void *user_data);

	sensor_listener_h listener;
	sensor_h sensor;
	typedef struct sensor_result{
		sensor_type_e sensorType;
		std::vector<int> sensorValue;
	}sensor_result_t;

	sensor_result_t Sres;
};

#endif /* TOOLS_SRC_SENSORPROCESS_H_ */
