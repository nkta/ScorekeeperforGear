S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.2
Build-Number: R732XXU2EQC1
Build-Date: 2017.03.13 20:32:41

Crash Information
Process Name: scorekeeperforgear
PID: 7429
Date: 2017-06-18 20:58:20+0200
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
r6   = 0x418cb3a4, r7   = 0xbea31480
r8   = 0x418b557d, r9   = 0xfffea3b5
r10  = 0xfffea3f1, fp   = 0xfffea415
ip   = 0x404d9b50, sp   = 0xbea311f8
lr   = 0x418b83d3, pc   = 0x404d9b58
cpsr = 0x60000010

Memory Information
MemTotal:   491132 KB
MemFree:     26524 KB
Buffers:     10488 KB
Cached:     122248 KB
VmPeak:      59428 KB
VmSize:      59424 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12008 KB
VmRSS:       12004 KB
VmData:       4260 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23100 KB
VmPTE:          38 KB
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
41490000 41494000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4149c000 414a4000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
414a6000 414ab000 r-xp /usr/lib/libappcore-common.so.1.1
414b3000 414b5000 r-xp /usr/lib/libiniparser.so.0
414d4000 414d8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
414e1000 414e3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
414ec000 414f2000 r-xp /usr/lib/libappsvc.so.0.1.0
414fa000 4151e000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41527000 415f6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4160c000 41616000 r-xp /lib/libnss_files-2.13.so
418b2000 418bb000 r-xp /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
418cc000 418d1000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
418d9000 418e5000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
418ee000 4190f000 r-xp /usr/lib/libefl-extension.so.0.1.0
41917000 4191c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41924000 4194e000 r-xp /usr/lib/libsensor.so.1.9.5
41957000 4195e000 r-xp /usr/lib/libctx-shared.so.0.8.3
41966000 4196b000 r-xp /usr/lib/libctx-client.so.0.8.3
41973000 41985000 r-xp /usr/lib/libefl-assist.so.0.1.0
4198d000 41a45000 r-xp /usr/lib/libcairo.so.2.11200.14
41a50000 41a5a000 r-xp /usr/lib/libsensord-shared.so
41a62000 41a71000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
41a7a000 41a90000 r-xp /usr/lib/libtts.so
41a99000 41abc000 r-xp /usr/lib/libui-extension.so.0.1.0
41ac5000 41ad0000 r-xp /usr/lib/libtbm.so.1.0.0
41ad8000 41ae6000 r-xp /usr/lib/libGLESv2.so.2.0
41aef000 41af0000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41af9000 41aff000 r-xp /usr/lib/libxcb-render.so.0.0.0
41b07000 41b0a000 r-xp /usr/lib/libEGL.so.1.4
41b12000 41b15000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41b1d000 41b1e000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41b27000 41caf000 r-xp /usr/lib/libicui18n.so.57.1
41cbf000 41dc5000 r-xp /usr/lib/libicuuc.so.57.1
41ddb000 41de3000 r-xp /usr/lib/libdrm.so.2.4.0
41deb000 41ded000 r-xp /usr/lib/libdri2.so.0.0.0
41df5000 41dfb000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41e03000 41e08000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41e10000 41e29000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
436ca000 436eb000 r-xp /usr/lib/libexif.so.12.3.3
436fe000 43700000 r-xp /usr/lib/libttrace.so.1.1
43708000 4370d000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43715000 4371b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43724000 4372c000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43734000 43756000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4375f000 43766000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4376f000 43771000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43779000 43780000 r-xp /usr/lib/libminizip.so.1.0.0
43788000 43795000 r-xp /usr/lib/libail.so.0.1.0
4379e000 437a4000 r-xp /usr/lib/libproc-stat.so.0.2.96
437ac000 437ad000 r-xp /usr/lib/libresponse.so.0.2.96
437b5000 437ba000 r-xp /usr/lib/libsystem.so.0.0.0
437c4000 4388e000 r-xp /usr/lib/libCOREGL.so.4.0
bea11000 bea32000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7429)
Call Stack Count: 6
 0: fclose + 0x8 (0x404d9b58) [/lib/libc.so.6] + 0x5cb58
 1: Configuration::createConfigurationTextFile() + 0x3e (0x418b83d3) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x63d3
 2: main + 0x32 (0x418b5493) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x3493
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
06-18 20:56:31.477+0200 W/WATCH_CORE(  937): appcore-watch.c: __widget_pause(1113) > widget_pause
06-18 20:56:31.477+0200 W/AUL     (  937): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.watchface.TacticalSentry) pid(937) status(bg) type(watchapp)
06-18 20:56:31.477+0200 W/W_INDICATOR(  796): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
06-18 20:56:31.477+0200 W/W_INDICATOR(  796): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
06-18 20:56:31.477+0200 W/W_INDICATOR(  796): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
06-18 20:56:31.477+0200 E/watchface-app(  937): watchface.cpp: OnAppPause(717) > 
06-18 20:56:31.972+0200 I/APP_CORE(  802): appcore-efl.c: __do_app(453) > [APP 802] Event: MEM_FLUSH State: PAUSED
06-18 20:56:36.477+0200 I/APP_CORE(  802): appcore-efl.c: __do_app(453) > [APP 802] Event: MEM_FLUSH State: PAUSED
06-18 20:57:27.642+0200 W/SHealthWidget( 1009): HeartRateWidgetViewController.cpp: OnTimerTick(164) > [1;35m BEGIN >>>>[0;m
06-18 20:57:27.642+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-18 20:57:27.642+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-18 20:57:27.642+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-18 20:57:27.642+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-18 20:57:27.657+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-18 20:57:27.657+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-18 20:57:27.662+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-18 20:57:27.662+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-18 20:57:27.692+0200 W/SHealthAppCommon( 1009): HeartRateLayout.cpp: UpdateTime(98) > [1;35mtimeString:[Il y a 15 h][0;m
06-18 20:57:27.697+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-18 20:57:27.707+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-18 20:57:27.707+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-18 20:57:27.712+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-18 20:57:27.717+0200 W/SHealthAppCommon( 1009): HeartRateLayout.cpp: SetEDCStateByCurrentHRValueType(264) > [1;35mhide_title_show_main_sub_text[0;m
06-18 20:57:27.727+0200 W/SHealthAppCommon( 1009): HeartRateLayout.cpp: CreateHeartRateSubTimeString(115) > [1;35mdurationMin:1016, diffSec:61018[0;m
06-18 20:57:27.727+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-18 20:57:27.727+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-18 20:57:27.727+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-18 20:57:27.732+0200 E/TIZEN_N_SYSTEM_SETTINGS( 1009): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-18 20:57:27.747+0200 W/SHealthAppCommon( 1009): HeartRateLayout.cpp: UpdateTagIcon(194) > [1;35mtag_icon_visible[0;m
06-18 20:57:27.747+0200 W/SHealthWidget( 1009): HeartRateWidgetViewController.cpp: OnTimerTick(177) > [1;35m END <<<<[0;m
06-18 20:58:04.152+0200 E/PKGMGR_SERVER( 7269): pkgmgr-server.c: main(2242) > package manager server start
06-18 20:58:04.272+0200 E/PKGMGR_SERVER( 7269): pkgmgr-server.c: req_cb(1135) > KILL_APP start 
06-18 20:58:04.292+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(669) > __request_handler: 14
06-18 20:58:04.307+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-18 20:58:04.307+0200 E/PKGMGR_SERVER( 7269): pkgmgr-server.c: req_cb(1154) > CHECK_KILL_APP done[return = 0] 
06-18 20:58:06.757+0200 E/PKGMGR_SERVER( 7269): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
06-18 20:58:06.757+0200 E/PKGMGR_SERVER( 7269): pkgmgr-server.c: main(2296) > package manager server terminated.
06-18 20:58:06.947+0200 E/PKGMGR  ( 7361): pkgmgr.c: pkgmgr_client_reinstall(1940) > reinstall pkg start.
06-18 20:58:07.132+0200 E/PKGMGR_SERVER( 7363): pkgmgr-server.c: main(2242) > package manager server start
06-18 20:58:07.257+0200 E/PKGMGR  ( 7363): pkgmgr-internal.c: _get_type_from_zip(735) > can not access to [org.example.scorekeeperforgear]
06-18 20:58:07.257+0200 E/PKGMGR_SERVER( 7363): pkgmgr-server.c: __get_type_from_msg(335) > pkgtype is null for org.example.scorekeeperforgear 
06-18 20:58:07.257+0200 E/PKGMGR_SERVER( 7363): pm-mdm.c: _get_package_info_from_file(1146) > [0;31m[_get_package_info_from_file(): 1146](ret < 0) access() failed. path: org.example.scorekeeperforgear errno: 2 (No such file or directory)[0;m
06-18 20:58:07.262+0200 E/PKGMGR  ( 7361): pkgmgr.c: pkgmgr_client_reinstall(2052) > reinstall pkg finish, ret=[73610002]
06-18 20:58:07.267+0200 E/PKGMGR_SERVER( 7364): pkgmgr-server.c: queue_job(1944) > INSTALL start, pkg path=[org.example.scorekeeperforgear]
06-18 20:58:07.272+0200 E/PKGMGR_SERVER( 7365): pkgmgr-server.c: queue_job(2138) > COMM_REQ_OBSERVER start, pkgid=[]
06-18 20:58:07.377+0200 E/rpm-installer( 7364): rpm-appcore-intf.c: main(120) > ------------------------------------------------
06-18 20:58:07.377+0200 E/rpm-installer( 7364): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
06-18 20:58:07.377+0200 E/rpm-installer( 7364): rpm-appcore-intf.c: main(122) > ------------------------------------------------
06-18 20:58:07.397+0200 E/PKGMGR_OBSERVER( 7365): pkg_observer.c: main(601) > OBSERVER start
06-18 20:58:07.612+0200 E/PKGMGR_OBSERVER( 7365): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[73650002] pkg_type[tpk] pkgid[org.example.scorekeeperforgear] key[start] val[update]
06-18 20:58:07.622+0200 I/watchface-app(  937): watchface-package-control.cpp: onPackageManagerEvent(120) > it is not my package
06-18 20:58:07.637+0200 W/W_HOME  (  802): clock_event.c: _pkgmgr_event_cb(210) > Pkg:org.example.scorekeeperforgear is being updateded:0
06-18 20:58:07.652+0200 W/AUL_AMD (  504): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(org.example.scorekeeperforgear), key(start), value(update)
06-18 20:58:07.652+0200 W/AUL_AMD (  504): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(997) > __amd_pkgmgrinfo_start_handler
06-18 20:58:07.662+0200 E/PKGMGR_OBSERVER( 7365): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[73650002] pkg_type[tpk] pkgid[org.example.scorekeeperforgear] key[install_percent] val[30]
06-18 20:58:07.667+0200 I/watchface-app(  937): watchface-package-control.cpp: onPackageManagerEvent(120) > it is not my package
06-18 20:58:07.682+0200 E/WMS     (  512): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [UPDATE, STARTED]
06-18 20:58:07.707+0200 E/WMS     (  512): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [UPDATE, PROCESSING]
06-18 20:58:07.842+0200 W/CERT_SVC( 7364): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
06-18 20:58:07.857+0200 E/rpm-installer( 7364): coretpk-parser.c: _coretpk_parser_get_manifest_info(1751) > (doc == NULL) xmlParseFile() failed.
06-18 20:58:07.862+0200 E/rpm-installer( 7364): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1639) > (pkg_file_info == NULL) pkg_file_info is NULL.
06-18 20:58:07.862+0200 E/rpm-installer( 7364): coretpk-installer.c: _coretpk_installer_package_reinstall(6741) > _coretpk_installer_verify_privilege_list failed
06-18 20:58:07.882+0200 E/PKGMGR_PARSER( 7364): pkgmgr_parser_signature.c: __ps_check_mdm_policy_by_pkgid(1056) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
06-18 20:58:07.907+0200 I/PRIVACY-MANAGER-CLIENT( 7364): SocketClient.cpp: SocketClient(37) > Client created
06-18 20:58:07.907+0200 I/PRIVACY-MANAGER-SERVER(  513): SocketService.cpp: mainloop(227) > Got incoming connection
06-18 20:58:07.907+0200 I/PRIVACY-MANAGER-CLIENT( 7364): SocketStream.h: SocketStream(31) > Created
06-18 20:58:07.907+0200 I/PRIVACY-MANAGER-CLIENT( 7364): SocketConnection.h: SocketConnection(44) > Created
06-18 20:58:07.907+0200 I/PRIVACY-MANAGER-CLIENT( 7364): SocketClient.cpp: connect(62) > Client connected
06-18 20:58:07.907+0200 I/PRIVACY-MANAGER-SERVER(  513): SocketService.cpp: connectionThread(253) > Starting connection thread
06-18 20:58:07.907+0200 I/PRIVACY-MANAGER-SERVER(  513): SocketStream.h: SocketStream(31) > Created
06-18 20:58:07.907+0200 I/PRIVACY-MANAGER-SERVER(  513): SocketConnection.h: SocketConnection(44) > Created
06-18 20:58:07.907+0200 I/PRIVACY-MANAGER-SERVER(  513): SocketService.cpp: connectionService(304) > Calling service
06-18 20:58:07.912+0200 I/PRIVACY-MANAGER-CLIENT( 7364): SocketClient.cpp: disconnect(72) > Client disconnected
06-18 20:58:07.912+0200 I/PRIVACY-MANAGER-SERVER(  513): SocketService.cpp: connectionService(307) > Removing client
06-18 20:58:07.912+0200 I/PRIVACY-MANAGER-SERVER(  513): SocketService.cpp: connectionService(311) > Call served
06-18 20:58:07.912+0200 I/PRIVACY-MANAGER-SERVER(  513): SocketService.cpp: connectionThread(262) > Client serviced
06-18 20:58:08.017+0200 E/rpm-installer( 7364): coretpk-installer.c: _coretpk_installer_package_reinstall(6795) > _coretpk_installer_package_reinstall(org.example.scorekeeperforgear) failed.
06-18 20:58:08.027+0200 E/PKGMGR_OBSERVER( 7365): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[73650002] pkg_type[tpk] pkgid[org.example.scorekeeperforgear] key[end] val[fail]
06-18 20:58:08.032+0200 E/PKGMGR_OBSERVER( 7365): pkg_observer.c: main(620) > OBSERVER end
06-18 20:58:08.037+0200 E/APP_SHORTCUT_WIDGET(  962): pkgmgr.c: _end(340) >  (strcasecmp(val, "ok")) -> _end() return
06-18 20:58:08.037+0200 E/APP_SHORTCUT_WIDGET(  962): pkgmgr.c: _pkgmgr_cb(398) >  pkgmgr_cbs[6].func has errors.
06-18 20:58:08.037+0200 I/watchface-app(  937): watchface-package-control.cpp: onPackageManagerEvent(120) > it is not my package
06-18 20:58:08.042+0200 E/APPS    (  802): pkgmgr.c: _end(777) >  (strcasecmp(val, "ok")) -> _end() return
06-18 20:58:08.042+0200 E/APPS    (  802): pkgmgr.c: _pkgmgr_cb(840) >  pkgmgr_cbs[6].func has errors.
06-18 20:58:08.062+0200 E/STARTER (  769): pkg-monitor.c: _pkg_monitor_get_mainappid(105) > [_pkg_monitor_get_mainappid:105] Failed to get pkginfo[-1]
06-18 20:58:08.072+0200 E/PKGMGR_SERVER( 7363): pkgmgr-server.c: sighandler(486) > child NORMAL exit [7365]
06-18 20:58:08.077+0200 W/AUL_AMD (  504): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(org.example.scorekeeperforgear), key(end), value(fail)
06-18 20:58:08.122+0200 E/WMS     (  512): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [UPDATE, COMPLETED]
06-18 20:58:08.122+0200 E/WMS     (  512): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7081) > package install complete
06-18 20:58:08.122+0200 E/WMS     (  512): wms_event_handler.c: _wms_event_handler_package_install_event(5035) > 
06-18 20:58:08.122+0200 E/WMS     (  512): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(2041) > Found in install_req_list?[0], index[-1]
06-18 20:58:09.757+0200 E/PKGMGR_SERVER( 7363): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
06-18 20:58:10.187+0200 E/rpm-installer( 7364): rpm-appcore-intf.c: main(273) > ------------------------------------------------
06-18 20:58:10.187+0200 E/rpm-installer( 7364): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
06-18 20:58:10.187+0200 E/rpm-installer( 7364): rpm-appcore-intf.c: main(275) > ------------------------------------------------
06-18 20:58:10.242+0200 E/PKGMGR_SERVER( 7363): pkgmgr-server.c: sighandler(486) > child NORMAL exit [7364]
06-18 20:58:10.282+0200 E/RESOURCED(  648): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/7364/oom_score_adj failed
06-18 20:58:10.282+0200 E/RESOURCED(  648): proc-main.c: resourced_proc_status_change(1508) > Empty pid or process not exists. 7364
06-18 20:58:11.757+0200 E/PKGMGR_SERVER( 7363): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
06-18 20:58:11.757+0200 E/PKGMGR_SERVER( 7363): pkgmgr-server.c: main(2296) > package manager server terminated.
06-18 20:58:11.972+0200 E/PKGMGR  ( 7415): pkgmgr.c: pkgmgr_client_install(1651) > install pkg start.
06-18 20:58:12.242+0200 E/PKGMGR_SERVER( 7417): pkgmgr-server.c: main(2242) > package manager server start
06-18 20:58:12.392+0200 E/PKGMGR  ( 7417): pkgmgr-internal.c: _get_type_from_zip(771) > /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-arm.tpk is core
06-18 20:58:12.402+0200 E/PKGMGR  ( 7417): pkgmgr-internal.c: _get_type_from_zip(771) > /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-arm.tpk is core
06-18 20:58:12.402+0200 E/rpm-installer( 7417): installer-util.c: _installer_util_delete_dir(420) > (dp == NULL) opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
06-18 20:58:12.417+0200 E/BACKEND_LIB( 7417): librpm.c: __is_symlink_file(70) > file is safe
06-18 20:58:12.442+0200 E/PKGMGR_SERVER( 7417): pm-mdm.c: _pm_check_mdm_policy(1063) > [0;31m[_pm_check_mdm_policy(): 1063](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
06-18 20:58:12.447+0200 E/PKGMGR  ( 7415): pkgmgr.c: pkgmgr_client_install(1768) > install pkg finish, ret=[74150002]
06-18 20:58:12.447+0200 E/PKGMGR_SERVER( 7418): pkgmgr-server.c: queue_job(1944) > INSTALL start, pkg path=[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-arm.tpk]
06-18 20:58:12.452+0200 E/PKGMGR_SERVER( 7419): pkgmgr-server.c: queue_job(2138) > COMM_REQ_OBSERVER start, pkgid=[]
06-18 20:58:12.542+0200 E/rpm-installer( 7418): rpm-appcore-intf.c: main(120) > ------------------------------------------------
06-18 20:58:12.542+0200 E/rpm-installer( 7418): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
06-18 20:58:12.542+0200 E/rpm-installer( 7418): rpm-appcore-intf.c: main(122) > ------------------------------------------------
06-18 20:58:12.572+0200 E/PKGMGR_OBSERVER( 7419): pkg_observer.c: main(601) > OBSERVER start
06-18 20:58:12.687+0200 E/rpm-installer( 7418): rpm-appcore-intf.c: main(207) > [/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-arm.tpk] is tpk package.
06-18 20:58:12.697+0200 E/rpm-installer( 7418): coretpk-parser.c: __coretpk_parser_get_value(1713) > (result_value == NULL) [install-location] is empty.
06-18 20:58:12.702+0200 E/rpm-installer( 7418): coretpk-parser.c: _coretpk_parser_is_widget(1586) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget'])
06-18 20:58:12.702+0200 E/rpm-installer( 7418): coretpk-parser.c: _coretpk_parser_is_custom_clock(1480) > (ret == 1) metadata(watchface) is empty.
06-18 20:58:12.702+0200 E/rpm-installer( 7418): installer-util.c: _installer_util_delete_dir(420) > (dp == NULL) opendir(/opt/usr/data/pkgmgr/org.example.scorekeeperforgear/) failed. [2][No such file or directory]
06-18 20:58:12.702+0200 E/rpm-installer( 7418): coretpk-installer.c: _coretpk_installer_install_package(3579) > Deletion failed: [/opt/usr/data/pkgmgr/org.example.scorekeeperforgear/]
06-18 20:58:12.807+0200 E/PKGMGR_OBSERVER( 7419): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[74190002] pkg_type[tpk] pkgid[org.example.scorekeeperforgear] key[start] val[install]
06-18 20:58:12.817+0200 E/APP_SHORTCUT_WIDGET(  962): pkgmgr.c: _start(234) >  (_exist_request_in_list(package)) -> _start() return
06-18 20:58:12.817+0200 E/APP_SHORTCUT_WIDGET(  962): pkgmgr.c: _pkgmgr_cb(398) >  pkgmgr_cbs[0].func has errors.
06-18 20:58:12.822+0200 I/watchface-app(  937): watchface-package-control.cpp: onPackageManagerEvent(120) > it is not my package
06-18 20:58:12.822+0200 E/APPS    (  802): pkgmgr.c: _start(495) >  (_exist_request_in_list(package)) -> _start() return
06-18 20:58:12.822+0200 E/APPS    (  802): pkgmgr.c: _pkgmgr_cb(840) >  pkgmgr_cbs[0].func has errors.
06-18 20:58:12.837+0200 W/AUL_AMD (  504): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(org.example.scorekeeperforgear), key(start), value(install)
06-18 20:58:12.847+0200 E/PKGMGR_OBSERVER( 7419): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[74190002] pkg_type[tpk] pkgid[org.example.scorekeeperforgear] key[install_percent] val[30]
06-18 20:58:12.857+0200 I/watchface-app(  937): watchface-package-control.cpp: onPackageManagerEvent(120) > it is not my package
06-18 20:58:12.872+0200 E/WMS     (  512): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, STARTED]
06-18 20:58:12.892+0200 E/WMS     (  512): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, PROCESSING]
06-18 20:58:13.152+0200 W/CERT_SVC( 7418): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
06-18 20:58:13.197+0200 E/rpm-installer( 7418): coretpk-parser.c: __coretpk_parser_verify_metadata(48) > (ret == 1) metadata is empty.
06-18 20:58:13.197+0200 E/rpm-installer( 7418): coretpk-parser.c: __coretpk_parser_append_path(417) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
06-18 20:58:13.197+0200 E/rpm-installer( 7418): coretpk-parser.c: __coretpk_parser_append_path(417) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
06-18 20:58:13.197+0200 E/rpm-installer( 7418): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(541) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
06-18 20:58:13.257+0200 E/PKGMGR_PARSER( 7418): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2167) > Manifest is Valid
06-18 20:58:13.257+0200 E/PKGMGR_PARSER( 7418): pkgmgr_parser.c: __parse_manifest_for_installation(1910) > parsing manifest for installation: /opt/share/packages/org.example.scorekeeperforgear.xml
06-18 20:58:13.267+0200 E/PKGMGR_PARSER( 7418): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
06-18 20:58:13.267+0200 E/PKGMGR_PARSER( 7418): pkgmgr_parser.c: __ps_process_tag(866) > tag is NULL
06-18 20:58:13.357+0200 I/PRIVACY-MANAGER-CLIENT( 7418): SocketClient.cpp: SocketClient(37) > Client created
06-18 20:58:13.447+0200 I/efl-extension( 7418): efl_extension.c: eext_mod_init(40) > Init
06-18 20:58:13.447+0200 I/efl-extension( 7418): efl_extension.c: eext_mod_shutdown(46) > Shutdown
06-18 20:58:13.522+0200 E/PKGMGR_PARSER( 7418): pkgmgr_parser.c: __parse_manifest_for_installation(1952) > parsing manifest for installation Done
06-18 20:58:13.552+0200 E/PKGMGR_CERT( 7418): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
06-18 20:58:13.552+0200 E/PKGMGR_CERT( 7418): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 146
06-18 20:58:13.557+0200 E/PKGMGR_CERT( 7418): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 146
06-18 20:58:13.557+0200 E/PKGMGR_CERT( 7418): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 44 6
06-18 20:58:13.557+0200 E/PKGMGR_CERT( 7418): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 45 6
06-18 20:58:13.557+0200 E/PKGMGR_CERT( 7418): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 46 6
06-18 20:58:13.557+0200 E/PKGMGR_CERT( 7418): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 47 6
06-18 20:58:13.572+0200 E/PKGMGR_CERT( 7418): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(575) > Transaction Commit and End
06-18 20:58:13.582+0200 E/PKGMGR_OBSERVER( 7419): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[74190002] pkg_type[tpk] pkgid[org.example.scorekeeperforgear] key[install_percent] val[60]
06-18 20:58:13.587+0200 E/rpm-installer( 7418): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1983) > skip! empty dirpath=[/opt/usr/apps/org.example.scorekeeperforgear/lib]
06-18 20:58:13.592+0200 I/watchface-app(  937): watchface-package-control.cpp: onPackageManagerEvent(120) > it is not my package
06-18 20:58:13.612+0200 E/WMS     (  512): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, PROCESSING]
06-18 20:58:13.672+0200 E/rpm-installer( 7418): installer-util.c: _installer_util_get_configuration_value(601) > [signature]=[on]
06-18 20:58:13.687+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 6880 pgid = 6880
06-18 20:58:13.687+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
06-18 20:58:13.692+0200 E/rpm-installer( 7418): coretpk-installer.c: _coretpk_installer_apply_smack(3199) > groupid = [jfTbrUA#2ogl2NTMzJsFaDf9C9RRbH6L1IYaOvZTT#U=] for shared/trusted.
06-18 20:58:13.737+0200 E/rpm-installer( 7418): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
06-18 20:58:13.762+0200 I/AUL_AMD (  504): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6880
06-18 20:58:13.762+0200 W/AUL     (  504): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6880)
06-18 20:58:13.792+0200 E/PKGMGR_OBSERVER( 7419): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[74190002] pkg_type[tpk] pkgid[org.example.scorekeeperforgear] key[install_percent] val[100]
06-18 20:58:13.802+0200 I/watchface-app(  937): watchface-package-control.cpp: onPackageManagerEvent(120) > it is not my package
06-18 20:58:13.817+0200 E/rpm-installer( 7418): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
06-18 20:58:13.842+0200 E/WMS     (  512): wms_event_handler.c: _wms_event_handler_cb_log_package(4745) > package [_________] callback : [INSTALL, PROCESSING]
06-18 20:58:13.882+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
06-18 20:58:13.882+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 6681 pgid = -1
06-18 20:58:13.882+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 9
06-18 20:58:13.882+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
06-18 20:58:13.897+0200 I/AUL_AMD (  504): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6681
06-18 20:58:13.897+0200 W/AUL     (  504): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6681)
06-18 20:58:14.182+0200 I/AUL_AMD (  504): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6682
06-18 20:58:14.182+0200 W/AUL     (  504): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6682)
06-18 20:58:14.757+0200 E/PKGMGR_SERVER( 7417): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
06-18 20:58:15.462+0200 I/AUL_PAD ( 7429): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
06-18 20:58:15.517+0200 W/MM_CAMCORDER( 7428): mm_camcorder_internal.c: _mmcamcorder_constructor(203) >  start
06-18 20:58:15.517+0200 W/MM_CAMCORDER( 7428): mm_camcorder_internal.c: _mmcamcorder_constructor(213) >  done
06-18 20:58:15.532+0200 I/efl-extension( 7428): efl_extension.c: eext_mod_init(40) > Init
06-18 20:58:15.997+0200 I/efl-extension( 7430): efl_extension.c: eext_mod_init(40) > Init
06-18 20:58:16.172+0200 I/UXT     ( 7430): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
06-18 20:58:16.287+0200 I/AUL_PAD ( 7430): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
06-18 20:58:16.317+0200 E/MALI    ( 7430): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
06-18 20:58:16.317+0200 E/MALI    ( 7430): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
06-18 20:58:16.317+0200 E/MALI    ( 7430): [gpu-ddk] devel/graphics_drv/r4p0
06-18 20:58:16.317+0200 E/MALI    ( 7430): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
06-18 20:58:16.317+0200 E/MALI    ( 7430): [coregl] devel/graphics_engine/master
06-18 20:58:16.317+0200 E/MALI    ( 7430): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
06-18 20:58:16.317+0200 E/MALI    ( 7430): 