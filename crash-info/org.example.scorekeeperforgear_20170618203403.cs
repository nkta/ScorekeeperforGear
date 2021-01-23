S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.2
Build-Number: R732XXU2EQC1
Build-Date: 2017.03.13 20:32:41

Crash Information
Process Name: scorekeeperforgear
PID: 5687
Date: 2017-06-18 20:34:03+0200
Executable File Path: /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000001
r2   = 0x00000000, r3   = 0x00000001
r4   = 0x00000000, r5   = 0xfffeec77
r6   = 0x416cb3a4, r7   = 0xbeec6480
r8   = 0x416b557d, r9   = 0xfffea3b5
r10  = 0xfffea3f1, fp   = 0xfffea415
ip   = 0x404d9b50, sp   = 0xbeec61f8
lr   = 0x416b83d3, pc   = 0x404d9b58
cpsr = 0x60000010

Memory Information
MemTotal:   491132 KB
MemFree:      6148 KB
Buffers:      9948 KB
Cached:     125208 KB
VmPeak:      59644 KB
VmSize:      59640 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11944 KB
VmRSS:       11940 KB
VmData:       4476 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23100 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
40000000 40005000 r-xp /usr/bin/launchpad-loader
4000d000 4002a000 r-xp /lib/ld-2.13.so
40033000 40037000 r-xp /usr/lib/libsys-assert.so
40041000 40047000 r-xp /usr/lib/libappcore-efl.so.1.1
40056000 40063000 r-xp /usr/lib/libaul.so.0.1.0
4006d000 4006f000 r-xp /lib/libdl-2.13.so
40078000 4007b000 r-xp /usr/lib/libbundle.so.0.1.22
40083000 40085000 r-xp /usr/lib/libdlog.so.0.0.0
4008d000 400a1000 r-xp /lib/libpthread-2.13.so
400ac000 401e8000 r-xp /usr/lib/libelementary.so.1.7.99
401ff000 402cd000 r-xp /usr/lib/libevas.so.1.7.99
402f2000 40309000 r-xp /usr/lib/libecore.so.1.7.99
40320000 4037e000 r-xp /usr/lib/libedje.so.1.7.99
40388000 40458000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40459000 4045f000 r-xp /usr/lib/libprivilege-control.so.0.0.2
40467000 4046b000 r-xp /usr/lib/libsmack.so.1.0.0
40474000 4047c000 r-xp /lib/libgcc_s-4.6.so.1
4047d000 405a1000 r-xp /lib/libc-2.13.so
405af000 405cd000 r-xp /usr/lib/libsystemd.so.0.4.0
405d7000 405e2000 r-xp /lib/libunwind.so.8.0.1
4060f000 40626000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
4062e000 40658000 r-xp /usr/lib/libdbus-1.so.3.8.12
40661000 40666000 r-xp /usr/lib/libxdgmime.so.1.1.0
4066e000 40691000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
40699000 4069a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
406a2000 406a8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406b1000 4071a000 r-xp /lib/libm-2.13.so
40723000 4073c000 r-xp /usr/lib/libeet.so.1.7.99
4074d000 4078e000 r-xp /usr/lib/libeina.so.1.7.99
40797000 407b9000 r-xp /usr/lib/libecore_evas.so.1.7.99
407c2000 407c7000 r-xp /usr/lib/libecore_file.so.1.7.99
407cf000 407e0000 r-xp /usr/lib/libecore_input.so.1.7.99
407e8000 407f1000 r-xp /usr/lib/libvconf.so.0.2.45
407f9000 40849000 r-xp /usr/lib/libecore_x.so.1.7.99
4084b000 40854000 r-xp /usr/lib/libedbus.so.1.7.99
4085c000 40876000 r-xp /usr/lib/libecore_con.so.1.7.99
4087f000 40892000 r-xp /usr/lib/libfribidi.so.0.3.1
4089a000 408df000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
408e8000 40910000 r-xp /usr/lib/libfontconfig.so.1.8.0
40911000 40967000 r-xp /usr/lib/libfreetype.so.6.11.3
40973000 409c9000 r-xp /usr/lib/libpixman-1.so.0.28.2
409d6000 409dc000 r-xp /lib/librt-2.13.so
409e5000 409ec000 r-xp /usr/lib/libembryo.so.1.7.99
409f4000 40a0b000 r-xp /usr/lib/liblua-5.1.so
40a14000 40a1a000 r-xp /usr/lib/libecore_imf.so.1.7.99
40a22000 40a23000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40a2b000 40a5a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40a62000 40a65000 r-xp /lib/libcap.so.2.21
40a6d000 40a85000 r-xp /usr/lib/liblzma.so.5.0.3
40a8d000 40a9d000 r-xp /lib/libresolv-2.13.so
40aa1000 40b74000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40b7f000 40bb3000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40bbc000 40bd6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40bde000 40c53000 r-xp /usr/lib/libsqlite3.so.0.8.6
40c5d000 40c5f000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
40c67000 40c7d000 r-xp /lib/libz.so.1.2.5
40c85000 40ca8000 r-xp /usr/lib/libjpeg.so.8.0.2
40cc0000 40da1000 r-xp /usr/lib/libX11.so.6.3.0
40dac000 40db1000 r-xp /usr/lib/libecore_fb.so.1.7.99
40dba000 40dbe000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40dc7000 40dca000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40dd2000 40dd9000 r-xp /usr/lib/libXcursor.so.1.0.2
40de1000 40de3000 r-xp /usr/lib/libXdamage.so.1.1.0
40deb000 40ded000 r-xp /usr/lib/libXcomposite.so.1.0.0
40df5000 40df7000 r-xp /usr/lib/libXgesture.so.7.0.0
40dff000 40e02000 r-xp /usr/lib/libXfixes.so.3.1.0
40e0a000 40e13000 r-xp /usr/lib/libXi.so.6.1.0
40e1b000 40e1c000 r-xp /usr/lib/libXinerama.so.1.0.0
40e25000 40e2b000 r-xp /usr/lib/libXrandr.so.2.2.0
40e33000 40e39000 r-xp /usr/lib/libXrender.so.1.3.0
40e41000 40e45000 r-xp /usr/lib/libXtst.so.6.1.0
40e4d000 40e57000 r-xp /usr/lib/libXext.so.6.4.0
40e60000 40ea4000 r-xp /usr/lib/libcurl.so.4.3.0
40ead000 40ec3000 r-xp /lib/libexpat.so.1.6.0
40ecd000 40ee5000 r-xp /usr/lib/libpng12.so.0.50.0
40eed000 40f0a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
40f13000 40fa7000 r-xp /usr/lib/libstdc++.so.6.0.16
40fba000 40fbd000 r-xp /lib/libattr.so.1.1.0
40fc5000 40fc6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
40fce000 40fd3000 r-xp /usr/lib/libffi.so.5.0.10
40fdc000 40fde000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
40fe6000 410b2000 r-xp /usr/lib/libxml2.so.2.7.8
410bf000 410c1000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
410ca000 410cc000 r-xp /usr/lib/journal/libjournal.so.0.1.0
410d4000 410e7000 r-xp /usr/lib/libxcb.so.1.1.0
410f1000 410fa000 r-xp /usr/lib/libcares.so.2.1.0
41103000 41131000 r-xp /usr/lib/libidn.so.11.5.44
41139000 41180000 r-xp /usr/lib/libssl.so.1.0.0
4118c000 4131e000 r-xp /usr/lib/libcrypto.so.1.0.0
41340000 41342000 r-xp /usr/lib/libiri.so
4134a000 41351000 r-xp /lib/libcrypt-2.13.so
41381000 41383000 r-xp /usr/lib/libXau.so.6.0.0
41390000 41394000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4139c000 413a4000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
413a6000 413ab000 r-xp /usr/lib/libappcore-common.so.1.1
413b3000 413b5000 r-xp /usr/lib/libiniparser.so.0
413d4000 413d8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
413e1000 413e3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
413ec000 413f2000 r-xp /usr/lib/libappsvc.so.0.1.0
413fa000 4141e000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41427000 414f6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4150c000 41516000 r-xp /lib/libnss_files-2.13.so
416b2000 416bb000 r-xp /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
416cc000 416d1000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
416d9000 416e5000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
416ee000 4170f000 r-xp /usr/lib/libefl-extension.so.0.1.0
41717000 4171c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41724000 4174e000 r-xp /usr/lib/libsensor.so.1.9.5
41757000 4175e000 r-xp /usr/lib/libctx-shared.so.0.8.3
41766000 4176b000 r-xp /usr/lib/libctx-client.so.0.8.3
41773000 41785000 r-xp /usr/lib/libefl-assist.so.0.1.0
4178d000 41845000 r-xp /usr/lib/libcairo.so.2.11200.14
41850000 4185a000 r-xp /usr/lib/libsensord-shared.so
41862000 41871000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
4187a000 41890000 r-xp /usr/lib/libtts.so
41899000 418bc000 r-xp /usr/lib/libui-extension.so.0.1.0
418c5000 418d0000 r-xp /usr/lib/libtbm.so.1.0.0
418d8000 418e6000 r-xp /usr/lib/libGLESv2.so.2.0
418ef000 418f0000 r-xp /usr/lib/libxcb-shm.so.0.0.0
418f9000 418ff000 r-xp /usr/lib/libxcb-render.so.0.0.0
41907000 4190a000 r-xp /usr/lib/libEGL.so.1.4
41912000 41915000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
4191d000 4191e000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41927000 41aaf000 r-xp /usr/lib/libicui18n.so.57.1
41abf000 41bc5000 r-xp /usr/lib/libicuuc.so.57.1
41bdb000 41be3000 r-xp /usr/lib/libdrm.so.2.4.0
41beb000 41bed000 r-xp /usr/lib/libdri2.so.0.0.0
41bf5000 41bfb000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41c03000 41c08000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41c10000 41c29000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
41c31000 41c52000 r-xp /usr/lib/libexif.so.12.3.3
41c65000 41c67000 r-xp /usr/lib/libttrace.so.1.1
41c6f000 41c74000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
41c7c000 41c82000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
41c8b000 41c93000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
41c9b000 41cbd000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
41cc6000 41ccd000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
41cd6000 41cd8000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
41ce0000 41ce7000 r-xp /usr/lib/libminizip.so.1.0.0
41cef000 41cfc000 r-xp /usr/lib/libail.so.0.1.0
41d05000 41d0b000 r-xp /usr/lib/libproc-stat.so.0.2.96
41d13000 41d14000 r-xp /usr/lib/libresponse.so.0.2.96
41d1c000 41d21000 r-xp /usr/lib/libsystem.so.0.0.0
41d2b000 41df5000 r-xp /usr/lib/libCOREGL.so.4.0
41dff000 41e23000 rw-p [heap]
41e23000 41f57000 rw-p [heap]
beea6000 beec7000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5687)
Call Stack Count: 6
 0: fclose + 0x8 (0x404d9b58) [/lib/libc.so.6] + 0x5cb58
 1: Configuration::createConfigurationTextFile() + 0x3e (0x416b83d3) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x63d3
 2: main + 0x32 (0x416b5493) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x3493
 3: (0x40001a53) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x1a53
 4: __libc_start_main + 0x114 (0x4049485c) [/lib/libc.so.6] + 0x1785c
 5:  + 0x0 (0x40001e0c) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x1e0c
End of Call Stack

Package Information
Package Name: org.example.scorekeeperforgear
Package ID : org.example.scorekeeperforgear
Version: 1.0.0
Package Type: rpm
App Name: scorekeeperforgear
App ID: org.example.scorekeeperforgear
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
_status_cb(487) > keep the news
06-18 20:33:55.407+0200 W/WAKEUP-SERVICE( 1378): WakeupService.cpp: OnReceiveGestureChanged(996) > [0;32mINFO: WakeupServiceStart[0;m
06-18 20:33:55.407+0200 W/WAKEUP-SERVICE( 1378): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
06-18 20:33:55.412+0200 W/W_HOME  (  802): gesture.c: _manual_render_enable(138) > 0
06-18 20:33:55.422+0200 I/APP_CORE(  802): appcore-efl.c: __do_app(453) > [APP 802] Event: RESUME State: PAUSED
06-18 20:33:55.422+0200 I/CAPI_APPFW_APPLICATION(  802): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-18 20:33:55.422+0200 W/W_HOME  (  802): main.c: _appcore_resume_cb(478) > appcore resume
06-18 20:33:55.422+0200 W/W_HOME  (  802): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
06-18 20:33:55.422+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:33:55.422+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:33:55.427+0200 W/W_HOME  (  802): main.c: home_resume(526) > journal_multimedia_screen_loaded_home called
06-18 20:33:55.427+0200 W/W_HOME  (  802): main.c: home_resume(530) > clock/widget resumed
06-18 20:33:55.427+0200 E/W_HOME  (  802): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
06-18 20:33:55.427+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:33:55.462+0200 W/WATCH_CORE(  937): appcore-watch.c: __widget_resume(1124) > widget_resume
06-18 20:33:55.462+0200 W/AUL     (  937): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.watchface.TacticalSentry) pid(937) status(fg) type(watchapp)
06-18 20:33:55.462+0200 E/watchface-app(  937): watchface.cpp: OnAppResume(725) > 
06-18 20:33:55.462+0200 E/clock-component(  937): clock-component-alarm.c: _clock_component_alarm_get_lastest_alarm(176) > [0;31malarm_list is [(nil)][0;m
06-18 20:33:55.462+0200 I/watchface-viewer(  937): viewer-part-resource.cpp: Start(1276) > mState[3]
06-18 20:33:55.467+0200 I/CAPI_WATCH_APPLICATION(  937): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-18 20:33:55.467+0200 E/watchface-app(  937): watchface.cpp: OnAppTimeTick(744) > 
06-18 20:33:55.477+0200 W/W_HOME  (  802): dbus.c: _dbus_message_recv_cb(186) > LCD on
06-18 20:33:55.477+0200 W/W_HOME  (  802): gesture.c: _manual_render_disable_timer_set(167) > timer set
06-18 20:33:55.477+0200 W/W_HOME  (  802): gesture.c: _manual_render_disable_timer_del(157) > timer del
06-18 20:33:55.482+0200 W/W_HOME  (  802): gesture.c: _apps_status_get(128) > apps status:0
06-18 20:33:55.482+0200 W/W_HOME  (  802): gesture.c: _lcd_on_cb(303) > move_to_clock:0 clock_visible:1 info->offtime:864
06-18 20:33:55.482+0200 W/W_HOME  (  802): gesture.c: _manual_render_schedule(209) > schedule, manual render
06-18 20:33:55.482+0200 W/W_HOME  (  802): event_manager.c: _lcd_on_cb(721) > lcd state: 1
06-18 20:33:55.482+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:33:55.482+0200 W/W_HOME  (  802): gesture.c: _widget_updated_cb(188) > widget updated
06-18 20:33:55.482+0200 W/W_HOME  (  802): gesture.c: _manual_render_disable_timer_del(157) > timer del
06-18 20:33:55.482+0200 W/W_HOME  (  802): gesture.c: _manual_render(182) > 
06-18 20:33:55.492+0200 W/W_HOME  (  802): gesture.c: _manual_render_enable(138) > 0
06-18 20:33:55.542+0200 W/W_INDICATOR(  796): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 1
06-18 20:33:55.542+0200 W/W_INDICATOR(  796): windicator_battery.c: windicator_battery_vconfkey_register(422) > [windicator_battery_vconfkey_register:422] Set battery cb
06-18 20:33:55.542+0200 W/W_INDICATOR(  796): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
06-18 20:33:55.777+0200 W/SHealthCommon( 1312): SystemUtil.cpp: OnDeviceStatusChanged(1064) > [1;35mlcdState:1[0;m
06-18 20:33:55.777+0200 W/SHealthService( 1312): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
06-18 20:33:55.842+0200 W/W_INDICATOR(  796): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(56), length(2)
06-18 20:33:55.847+0200 W/W_INDICATOR(  796): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 56%
06-18 20:33:55.847+0200 W/W_INDICATOR(  796): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 56, isCharging: 0
06-18 20:33:55.847+0200 I/TIZEN_N_SOUND_MANAGER( 1378): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
06-18 20:33:55.847+0200 W/W_INDICATOR(  796): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_60
06-18 20:33:55.872+0200 W/TIZEN_N_SOUND_MANAGER( 1378): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
06-18 20:33:55.872+0200 W/W_INDICATOR(  796): windicator_battery.c: windicator_battery_icon_update(381) > [windicator_battery_icon_update:381] Normal charging status !!
06-18 20:33:55.882+0200 W/W_INDICATOR(  796): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
06-18 20:33:55.882+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
06-18 20:33:55.907+0200 E/WAKEUP-SERVICE( 1378): WakeupService.cpp: _WakeupIsAvailable(327) > [0;31mERROR: db/knoxcustom/prokiosk_state_enable FAILED[0;m
06-18 20:33:55.927+0200 W/W_INDICATOR(  796): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[gesture],charge : 0, connected : 0
06-18 20:33:55.937+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
06-18 20:33:55.937+0200 I/TIZEN_N_SOUND_MANAGER( 1378): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
06-18 20:33:55.937+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: preference_get_boolean(1173) > preference_get_boolean(1312) : test_healthy_pace error
06-18 20:33:55.942+0200 I/TIZEN_N_SOUND_MANAGER( 1378): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
06-18 20:33:55.942+0200 W/TIZEN_N_SOUND_MANAGER( 1378): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
06-18 20:33:55.992+0200 W/WAKEUP-SERVICE( 1378): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
06-18 20:33:55.992+0200 I/HIGEAR  ( 1378): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
06-18 20:33:55.997+0200 I/CAPI_WATCH_APPLICATION(  937): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-18 20:33:55.997+0200 E/watchface-app(  937): watchface.cpp: OnAppTimeTick(744) > 
06-18 20:33:55.997+0200 I/watchface-viewer(  937): viewer-part-resource-evas.cpp: CreateTextImage(807) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=center ']
06-18 20:33:55.997+0200 I/watchface-viewer(  937): viewer-part-resource-evas.cpp: CreateTextImage(821) > formatted size 275x63
06-18 20:33:55.997+0200 I/watchface-viewer(  937): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(577) > ImagesLoadingDoneSignal().Emit()
06-18 20:33:56.027+0200 W/WAKEUP-SERVICE( 1378): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : 1075006220[0;m
06-18 20:33:56.042+0200 W/WAKEUP-SERVICE( 1378): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
06-18 20:33:56.062+0200 W/WAKEUP-SERVICE( 1378): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
06-18 20:33:56.067+0200 I/TIZEN_N_SOUND_MANAGER( 1378): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
06-18 20:33:56.102+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
06-18 20:33:56.177+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
06-18 20:33:56.197+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: preference_get_double(1214) > preference_get_double(1312) : pedometer_inactive_period error
06-18 20:33:56.197+0200 W/TIZEN_N_SOUND_MANAGER( 1378): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
06-18 20:33:56.207+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
06-18 20:33:56.217+0200 W/WATCH_CORE(  937): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 2
06-18 20:33:56.217+0200 I/WATCH_CORE(  937): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
06-18 20:33:56.217+0200 I/CAPI_WATCH_APPLICATION(  937): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-18 20:33:56.217+0200 E/watchface-app(  937): watchface.cpp: OnAppTimeTick(744) > 
06-18 20:33:56.292+0200 W/STARTER (  769): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [gesture]
06-18 20:33:56.292+0200 W/STARTER (  769): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
06-18 20:33:56.292+0200 W/WATCH_CORE(  937): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
06-18 20:33:56.292+0200 E/STARTER (  769): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
06-18 20:33:56.292+0200 W/STARTER (  769): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
06-18 20:33:56.292+0200 W/STARTER (  769): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
06-18 20:33:56.397+0200 I/watchface-viewer(  937): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
06-18 20:33:56.402+0200 W/SHealthCommon( 1009): SystemUtil.cpp: OnDeviceStatusChanged(1064) > [1;35mlcdState:3[0;m
06-18 20:33:56.427+0200 I/w-magazine-widget(  979): widget.c: _magazine_widget_display_status_cb(493) > LCD off
06-18 20:33:56.427+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-18 20:33:56.432+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-18 20:33:56.432+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-18 20:33:56.432+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-18 20:33:56.432+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-18 20:33:56.432+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-18 20:33:56.432+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-18 20:33:56.432+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-18 20:33:56.432+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-18 20:33:56.432+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: preference_get_double(1214) > preference_get_double(1312) : inactive_10min_precaution_millisec error
06-18 20:33:56.437+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-18 20:33:56.437+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-18 20:33:56.437+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-18 20:33:56.437+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-18 20:33:56.437+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-18 20:33:56.437+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-18 20:33:56.437+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-18 20:33:56.437+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-18 20:33:56.437+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-18 20:33:56.437+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-18 20:33:56.437+0200 E/CAPI_APPFW_APP_CONTROL( 1110): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-18 20:33:56.437+0200 W/MUSIC_CONTROL_SERVICE( 1110): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1110]   [com.samsung.w-home]register msg port [true][0m
06-18 20:33:56.442+0200 W/STARTER (  769): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [gesture]
06-18 20:33:56.442+0200 W/STARTER (  769): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
06-18 20:33:56.442+0200 W/STARTER (  769): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
06-18 20:33:56.442+0200 W/STARTER (  769): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[1]
06-18 20:33:56.442+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 14
06-18 20:33:56.442+0200 W/W_HOME  (  802): dbus.c: _dbus_message_recv_cb(204) > LCD off
06-18 20:33:56.442+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
06-18 20:33:56.442+0200 W/W_HOME  (  802): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
06-18 20:33:56.442+0200 W/W_HOME  (  802): gesture.c: _manual_render_disable_timer_del(157) > timer del
06-18 20:33:56.442+0200 W/W_HOME  (  802): gesture.c: _manual_render_enable(138) > 1
06-18 20:33:56.447+0200 W/W_HOME  (  802): event_manager.c: _lcd_off_cb(729) > lcd state: 0
06-18 20:33:56.447+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:33:56.447+0200 E/WAKEUP-SERVICE( 1378): WakeupService.cpp: _WakeupIsAvailable(327) > [0;31mERROR: db/knoxcustom/prokiosk_state_enable FAILED[0;m
06-18 20:33:56.447+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 802
06-18 20:33:56.447+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-18 20:33:56.452+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: preference_get_double(1214) > preference_get_double(1312) : inactive_before_10min_precaution_millisec error
06-18 20:33:56.457+0200 I/APP_CORE(  802): appcore-efl.c: __do_app(453) > [APP 802] Event: PAUSE State: RUNNING
06-18 20:33:56.457+0200 I/CAPI_APPFW_APPLICATION(  802): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-18 20:33:56.457+0200 W/W_HOME  (  802): main.c: _appcore_pause_cb(487) > appcore pause
06-18 20:33:56.457+0200 W/W_HOME  (  802): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
06-18 20:33:56.457+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:33:56.457+0200 W/MUSIC_CONTROL_SERVICE( 1110): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1110]   [MUSIC_PLAYER_EVENT][0m
06-18 20:33:56.462+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:33:56.462+0200 W/W_HOME  (  802): main.c: home_pause(546) > clock/widget paused
06-18 20:33:56.462+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:33:56.462+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-18 20:33:56.462+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-18 20:33:56.462+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-18 20:33:56.462+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-18 20:33:56.462+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-18 20:33:56.462+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-18 20:33:56.462+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-18 20:33:56.462+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-18 20:33:56.462+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-18 20:33:56.462+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-18 20:33:56.462+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-18 20:33:56.462+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-18 20:33:56.462+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-18 20:33:56.462+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-18 20:33:56.462+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-18 20:33:56.462+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-18 20:33:56.467+0200 W/MUSIC_CONTROL_SERVICE( 1110): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1110]   [MUSIC_PLAYER_EVENT][0m
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-18 20:33:56.467+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-18 20:33:56.472+0200 W/W_HOME  (  802): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
06-18 20:33:56.472+0200 E/W_HOME  (  802): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
06-18 20:33:56.477+0200 W/WATCH_CORE(  937): appcore-watch.c: __widget_pause(1113) > widget_pause
06-18 20:33:56.477+0200 W/AUL     (  937): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.watchface.TacticalSentry) pid(937) status(bg) type(watchapp)
06-18 20:33:56.477+0200 E/watchface-app(  937): watchface.cpp: OnAppPause(717) > 
06-18 20:33:56.482+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-18 20:33:56.482+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-18 20:33:56.482+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-18 20:33:56.482+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-18 20:33:56.482+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-18 20:33:56.482+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-18 20:33:56.482+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-18 20:33:56.482+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-18 20:33:56.482+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-18 20:33:56.482+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-18 20:33:56.487+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-18 20:33:56.487+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-18 20:33:56.487+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-18 20:33:56.487+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-18 20:33:56.487+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-18 20:33:56.487+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-18 20:33:56.487+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-18 20:33:56.487+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-18 20:33:56.487+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-18 20:33:56.487+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-18 20:33:56.487+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-18 20:33:56.487+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-18 20:33:56.487+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-18 20:33:56.487+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-18 20:33:56.487+0200 I/MESSAGE_PORT(  484): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-18 20:33:56.487+0200 I/MESSAGE_PORT(  484): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-18 20:33:56.487+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-18 20:33:56.487+0200 I/MESSAGE_PORT(  484): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-18 20:33:56.487+0200 E/CAPI_APPFW_APP_CONTROL( 1110): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-18 20:33:56.487+0200 W/MUSIC_CONTROL_SERVICE( 1110): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1110]   [com.samsung.w-home]register msg port [false][0m
06-18 20:33:56.487+0200 W/W_HOME  (  802): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
06-18 20:33:56.487+0200 E/W_HOME  (  802): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
06-18 20:33:56.512+0200 W/SHealthCommon( 1312): SystemUtil.cpp: OnDeviceStatusChanged(1064) > [1;35mlcdState:3[0;m
06-18 20:33:56.512+0200 I/TIZEN_N_SOUND_MANAGER( 1378): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
06-18 20:33:56.517+0200 W/SHealthService( 1312): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
06-18 20:33:56.517+0200 I/TIZEN_N_SOUND_MANAGER( 1378): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
06-18 20:33:56.517+0200 W/TIZEN_N_SOUND_MANAGER( 1378): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
06-18 20:33:56.522+0200 W/W_INDICATOR(  796): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
06-18 20:33:56.522+0200 W/WAKEUP-SERVICE( 1378): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
06-18 20:33:56.522+0200 I/HIGEAR  ( 1378): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
06-18 20:33:56.522+0200 W/WAKEUP-SERVICE( 1378): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : 1075006220[0;m
06-18 20:33:56.522+0200 W/WAKEUP-SERVICE( 1378): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
06-18 20:33:56.522+0200 W/WAKEUP-SERVICE( 1378): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
06-18 20:33:56.522+0200 E/WAKEUP-SERVICE( 1378): WakeupService.cpp: _WakeupIsAvailable(327) > [0;31mERROR: db/knoxcustom/prokiosk_state_enable FAILED[0;m
06-18 20:33:56.532+0200 I/TIZEN_N_SOUND_MANAGER( 1378): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
06-18 20:33:56.537+0200 I/TIZEN_N_SOUND_MANAGER( 1378): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
06-18 20:33:56.537+0200 W/TIZEN_N_SOUND_MANAGER( 1378): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
06-18 20:33:56.537+0200 W/WAKEUP-SERVICE( 1378): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
06-18 20:33:56.542+0200 I/HIGEAR  ( 1378): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
06-18 20:33:56.632+0200 W/W_INDICATOR(  796): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
06-18 20:33:56.632+0200 W/W_INDICATOR(  796): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-18 20:33:56.637+0200 W/W_INDICATOR(  796): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
06-18 20:33:56.637+0200 W/W_INDICATOR(  796): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
06-18 20:33:56.637+0200 W/W_INDICATOR(  796): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
06-18 20:33:56.767+0200 I/AUL     ( 5689): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-18 20:33:56.782+0200 I/AUL     ( 5689): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-18 20:33:56.782+0200 E/AUL     ( 5689): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
06-18 20:33:56.782+0200 E/AUL     ( 5689): aul_path.c: __get_path(169) > root_path is NULL!
06-18 20:33:56.797+0200 I/AUL     ( 5689): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-18 20:33:56.807+0200 I/AUL     ( 5689): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-18 20:33:56.807+0200 E/AUL     ( 5689): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
06-18 20:33:56.807+0200 E/AUL     ( 5689): aul_path.c: __get_path(169) > root_path is NULL!
06-18 20:33:56.822+0200 I/AUL     ( 5689): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-18 20:33:56.837+0200 I/AUL     ( 5689): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-18 20:33:56.837+0200 E/AUL     ( 5689): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
06-18 20:33:56.837+0200 E/AUL     ( 5689): aul_path.c: __get_path(169) > root_path is NULL!
06-18 20:33:56.847+0200 I/AUL     ( 5689): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-18 20:33:56.862+0200 I/AUL     ( 5689): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-18 20:33:56.862+0200 E/AUL     ( 5689): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
06-18 20:33:56.862+0200 E/AUL     ( 5689): aul_path.c: __get_path(169) > root_path is NULL!
06-18 20:33:56.877+0200 I/AUL     ( 5689): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-18 20:33:56.897+0200 I/AUL     ( 5689): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-18 20:33:56.897+0200 E/AUL     ( 5689): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
06-18 20:33:56.902+0200 E/AUL     ( 5689): aul_path.c: __get_path(169) > root_path is NULL!
06-18 20:33:56.917+0200 I/AUL     ( 5689): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-18 20:33:56.932+0200 I/AUL     ( 5689): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-18 20:33:56.937+0200 E/AUL     ( 5689): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
06-18 20:33:56.937+0200 E/AUL     ( 5689): aul_path.c: __get_path(169) > root_path is NULL!
06-18 20:33:56.952+0200 I/AUL     ( 5689): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-18 20:33:56.967+0200 I/APP_CORE(  802): appcore-efl.c: __do_app(453) > [APP 802] Event: MEM_FLUSH State: PAUSED
06-18 20:33:56.997+0200 I/AUL     ( 5689): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-18 20:33:57.007+0200 E/AUL     ( 5689): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
06-18 20:33:57.007+0200 E/AUL     ( 5689): aul_path.c: __get_path(169) > root_path is NULL!
06-18 20:33:57.052+0200 I/AUL     ( 5689): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-18 20:33:57.107+0200 I/AUL     ( 5689): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-18 20:33:57.107+0200 E/AUL     ( 5689): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
06-18 20:33:57.117+0200 E/AUL     ( 5689): aul_path.c: __get_path(169) > root_path is NULL!
06-18 20:33:57.202+0200 I/UXT     ( 5689): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
06-18 20:33:57.392+0200 E/MALI    ( 5689): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
06-18 20:33:57.392+0200 E/MALI    ( 5689): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
06-18 20:33:57.392+0200 E/MALI    ( 5689): [gpu-ddk] devel/graphics_drv/r4p0
06-18 20:33:57.392+0200 E/MALI    ( 5689): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
06-18 20:33:57.392+0200 E/MALI    ( 5689): [coregl] devel/graphics_engine/master
06-18 20:33:57.392+0200 E/MALI    ( 5689): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
06-18 20:33:57.392+0200 E/MALI    ( 5689): 
06-18 20:33:58.187+0200 I/MALI    ( 5689): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x360]
06-18 20:33:58.187+0200 E/MALI    ( 5689): egl_mali.c: __egl_mali_post_to_window_surface(1183) > MALI_ERR_EARLY_OUT - Don't need to add frame callback because frame is unmodified
06-18 20:33:58.217+0200 I/AUL     ( 5777): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
06-18 20:33:58.237+0200 I/AUL     ( 5777): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-18 20:33:58.237+0200 E/AUL     ( 5777): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
06-18 20:33:58.237+0200 E/AUL     ( 5777): aul_path.c: __get_path(169) > root_path is NULL!
06-18 20:34:01.007+0200 I/watchface-viewer(  937): viewer-data-provider.cpp: AddPendingChanges(2230) > added [50] to pending list
06-18 20:34:01.472+0200 I/APP_CORE(  802): appcore-efl.c: __do_app(453) > [APP 802] Event: MEM_FLUSH State: PAUSED
06-18 20:34:02.012+0200 E/PKGMGR_SERVER( 5846): pkgmgr-server.c: main(2242) > package manager server start
06-18 20:34:02.137+0200 E/PKGMGR_SERVER( 5846): pkgmgr-server.c: req_cb(1135) > KILL_APP start 
06-18 20:34:02.177+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 14
06-18 20:34:02.192+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-18 20:34:02.192+0200 E/PKGMGR_SERVER( 5846): pkgmgr-server.c: req_cb(1154) > CHECK_KILL_APP done[return = 0] 
06-18 20:34:03.652+0200 W/AUL     ( 5895): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.scorekeeperforgear)
06-18 20:34:03.657+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 0
06-18 20:34:03.677+0200 I/AUL_AMD (  504): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
06-18 20:34:03.692+0200 I/AUL_AMD (  504): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
06-18 20:34:03.692+0200 E/AUL_AMD (  504): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
06-18 20:34:03.692+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(1782) > caller pid : 5895
06-18 20:34:03.707+0200 E/RESOURCED(  648): block.c: block_prelaunch_state(138) > insert data org.example.scorekeeperforgear, table num : 4
06-18 20:34:03.712+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(2218) > pad pid(-5)
06-18 20:34:03.712+0200 W/AUL_PAD ( 1304): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
06-18 20:34:03.712+0200 W/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(272) > Check app launching
06-18 20:34:03.717+0200 W/AUL_PAD ( 5687): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
06-18 20:34:03.717+0200 W/AUL_PAD ( 5687): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
06-18 20:34:03.717+0200 W/AUL_PAD ( 5687): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
06-18 20:34:03.722+0200 W/AUL_PAD ( 5687): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.scorekeeperforgear)
06-18 20:34:03.782+0200 I/efl-extension( 5687): efl_extension.c: eext_mod_init(40) > Init
06-18 20:34:03.787+0200 I/UXT     ( 5687): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
06-18 20:34:03.807+0200 W/AUL_PAD ( 5687): launchpad_loader.c: main(690) > [candidate] dlsym
06-18 20:34:03.807+0200 W/AUL_PAD ( 5687): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.scorekeeperforgear)
06-18 20:34:03.852+0200 W/WATCH_CORE(  937): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
06-18 20:34:03.852+0200 I/WATCH_CORE(  937): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
06-18 20:34:03.852+0200 I/CAPI_WATCH_APPLICATION(  937): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-18 20:34:03.852+0200 E/watchface-app(  937): watchface.cpp: OnAppTimeTick(744) > 
06-18 20:34:03.852+0200 I/watchface-app(  937): watchface.cpp: OnAppTimeTick(756) > set force update!!
06-18 20:34:03.852+0200 I/watchface-viewer(  937): viewer-part-resource-evas.cpp: CreateTextImage(807) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=center ']
06-18 20:34:03.852+0200 I/watchface-viewer(  937): viewer-part-resource-evas.cpp: CreateTextImage(821) > formatted size 274x63
06-18 20:34:03.857+0200 W/WAKEUP-SERVICE( 1378): WakeupService.cpp: OnReceiveGestureChanged(995) > [0;32mINFO: wakeup receive data : 1127370264[0;m
06-18 20:34:03.857+0200 W/WAKEUP-SERVICE( 1378): WakeupService.cpp: OnReceiveGestureChanged(996) > [0;32mINFO: WakeupServiceStart[0;m
06-18 20:34:03.857+0200 W/WAKEUP-SERVICE( 1378): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
06-18 20:34:03.857+0200 I/TIZEN_N_SOUND_MANAGER( 1378): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
06-18 20:34:03.857+0200 W/W_HOME  (  802): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
06-18 20:34:03.857+0200 W/W_HOME  (  802): gesture.c: _manual_render_schedule(209) > schedule, manual render
06-18 20:34:03.872+0200 I/watchface-viewer(  937): viewer-part-resource-evas.cpp: CreateTextImage(807) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=center ']
06-18 20:34:03.877+0200 I/watchface-viewer(  937): viewer-part-resource-evas.cpp: CreateTextImage(821) > formatted size 178x63
06-18 20:34:03.882+0200 I/watchface-viewer(  937): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(577) > ImagesLoadingDoneSignal().Emit()
06-18 20:34:03.892+0200 W/wnotibp ( 3533): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(91) > ::APP:: view state=0, 2, 0
06-18 20:34:03.892+0200 I/wnotibp ( 3533): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(140) > There is no additional work.
06-18 20:34:03.897+0200 W/WATCH_CORE(  937): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
06-18 20:34:03.897+0200 I/WATCH_CORE(  937): appcore-watch.c: __signal_lcd_status_handler(1250) > Call the time_tick_cb
06-18 20:34:03.897+0200 I/CAPI_WATCH_APPLICATION(  937): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-18 20:34:03.897+0200 E/watchface-app(  937): watchface.cpp: OnAppTimeTick(744) > 
06-18 20:34:03.902+0200 I/watchface-app(  937): watchface.cpp: OnAppTimeTick(756) > set force update!!
06-18 20:34:03.902+0200 I/WATCH_CORE(  937): appcore-watch.c: __signal_lcd_status_handler(1257) > Call widget_provider_update_event
06-18 20:34:03.902+0200 W/W_HOME  (  802): gesture.c: _widget_updated_cb(188) > widget updated
06-18 20:34:03.902+0200 W/W_HOME  (  802): gesture.c: _manual_render_disable_timer_del(157) > timer del
06-18 20:34:03.902+0200 W/W_HOME  (  802): gesture.c: _manual_render(182) > 
06-18 20:34:03.917+0200 W/STARTER (  769): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [gesture] after screen off time [7636]ms
06-18 20:34:03.917+0200 W/STARTER (  769): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[0]
06-18 20:34:03.937+0200 W/W_INDICATOR(  796): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
06-18 20:34:03.957+0200 I/watchface-viewer(  937): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
06-18 20:34:03.962+0200 W/SHealthCommon( 1009): SystemUtil.cpp: OnDeviceStatusChanged(1064) > [1;35mlcdState:1[0;m
06-18 20:34:04.012+0200 W/STARTER (  769): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [gesture]
06-18 20:34:04.012+0200 W/STARTER (  769): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
06-18 20:34:04.052+0200 W/W_HOME  (  802): gesture.c: _manual_render(182) > 
06-18 20:34:04.082+0200 I/w-magazine-widget(  979): widget.c: _magazine_widget_display_status_cb(463) > LCD on
06-18 20:34:04.132+0200 W/W_HOME  (  802): gesture.c: _manual_render_enable(138) > 0
06-18 20:34:04.137+0200 I/APP_CORE(  802): appcore-efl.c: __do_app(453) > [APP 802] Event: RESUME State: PAUSED
06-18 20:34:04.137+0200 I/CAPI_APPFW_APPLICATION(  802): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-18 20:34:04.137+0200 W/W_HOME  (  802): main.c: _appcore_resume_cb(478) > appcore resume
06-18 20:34:04.137+0200 W/W_HOME  (  802): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
06-18 20:34:04.137+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:34:04.142+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:34:04.142+0200 W/W_HOME  (  802): main.c: home_resume(526) > journal_multimedia_screen_loaded_home called
06-18 20:34:04.142+0200 W/W_HOME  (  802): main.c: home_resume(530) > clock/widget resumed
06-18 20:34:04.147+0200 E/W_HOME  (  802): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
06-18 20:34:04.147+0200 W/W_HOME  (  802): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-18 20:34:04.152+0200 W/CRASH_MANAGER( 5752): worker.c: worker_job(1205) > 110568773636f149781084
