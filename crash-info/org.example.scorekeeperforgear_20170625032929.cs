S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.2
Build-Number: R732XXU2EQC1
Build-Date: 2017.03.13 20:32:41

Crash Information
Process Name: scorekeeperforgear
PID: 14147
Date: 2017-06-25 03:29:29+0200
Executable File Path: /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x4

Register Information
r0   = 0x00000000, r1   = 0x416ba5ac
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xbe94b4c0, r5   = 0x41392980
r6   = 0x00000274, r7   = 0xbe94ac48
r8   = 0x41a86430, r9   = 0x00003743
r10  = 0x41a79978, fp   = 0x00000000
ip   = 0x416cbd8c, sp   = 0xbe94ac40
lr   = 0x416b5991, pc   = 0x416b9c8e
cpsr = 0x20000030

Memory Information
MemTotal:   491132 KB
MemFree:      4892 KB
Buffers:      9028 KB
Cached:      98084 KB
VmPeak:      84040 KB
VmSize:      84036 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16540 KB
VmRSS:       16536 KB
VmData:      24452 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23316 KB
VmPTE:          46 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 14147 TID = 14147
14147 14180 14181 

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
413be000 413c9000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
413d4000 413d8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
413e1000 413e3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
413ec000 413f2000 r-xp /usr/lib/libappsvc.so.0.1.0
413fa000 4141e000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41427000 414f6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4150c000 41516000 r-xp /lib/libnss_files-2.13.so
416b2000 416bc000 r-xp /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
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
41927000 4192f000 r-xp /usr/lib/libdrm.so.2.4.0
41937000 41939000 r-xp /usr/lib/libdri2.so.0.0.0
41941000 41947000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
4194f000 41954000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
4195c000 41975000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
4197d000 4197f000 r-xp /usr/lib/libttrace.so.1.1
41987000 41abc000 rw-p [heap]
41abc000 41c44000 r-xp /usr/lib/libicui18n.so.57.1
41c54000 41d5a000 r-xp /usr/lib/libicuuc.so.57.1
43609000 4362a000 r-xp /usr/lib/libexif.so.12.3.3
4363d000 43642000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
4364a000 43650000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43659000 43661000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43669000 4368b000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43694000 4369b000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
436a4000 436a6000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
436ae000 436b5000 r-xp /usr/lib/libminizip.so.1.0.0
436bd000 436ca000 r-xp /usr/lib/libail.so.0.1.0
436d3000 436d9000 r-xp /usr/lib/libproc-stat.so.0.2.96
436e1000 436e2000 r-xp /usr/lib/libresponse.so.0.2.96
436ea000 436ef000 r-xp /usr/lib/libsystem.so.0.0.0
436f9000 437c3000 r-xp /usr/lib/libCOREGL.so.4.0
43bf4000 43bff000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c08000 43c0d000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43c15000 43c2c000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43c39000 43c3b000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43c44000 44443000 rw-p [stack:14180]
44443000 44444000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
4460b000 451e1000 rw-p [stack:14181]
be92b000 be94c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14147)
Call Stack Count: 19
 0: SensorProcess::getSensorValue() + 0x65 (0x416b9c8e) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x7c8e
 1: app_resume(void*) + 0x1c (0x416b5991) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x3991
 2: (0x41391bf9) [/usr/lib/libcapi-appfw-application.so.0] + 0x1bf9
 3: (0x400441ed) [/usr/lib/libappcore-efl.so.1] + 0x31ed
 4: (0x413a7d1f) [/usr/lib/libappcore-common.so.1] + 0x1d1f
 5: (0x4005a495) [/usr/lib/libaul.so.0] + 0x4495
 6: (0x4005afad) [/usr/lib/libaul.so.0] + 0x4fad
 7: (0x403bbfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
 8: g_main_context_dispatch + 0xbc (0x403bd7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
 9: (0x40302ca7) [/usr/lib/libecore.so.1] + 0x10ca7
10: (0x402fdb4f) [/usr/lib/libecore.so.1] + 0xbb4f
11: (0x402fe4d5) [/usr/lib/libecore.so.1] + 0xc4d5
12: ecore_main_loop_begin + 0x30 (0x402fe879) [/usr/lib/libecore.so.1] + 0xc879
13: appcore_efl_main + 0x332 (0x40044b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
14: ui_app_main + 0xb0 (0x41392421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
15: main + 0xc2 (0x416b56eb) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x36eb
16:  + 0x0 (0x40001a53) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x1a53
17: __libc_start_main + 0x114 (0x4049485c) [/lib/libc.so.6] + 0x1785c
18: (0x40001e0c) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x1e0c
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
W/W_HOME  (  840): event_manager.c: _home_scroll_cb(585) > scroll,will,done
06-25 03:29:26.914+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 03:29:26.914+0200 W/W_HOME  (  840): event_manager.c: _home_scroll_cb(585) > scroll,done
06-25 03:29:26.914+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 03:29:26.994+0200 I/CAPI_WATCH_APPLICATION(  935): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-25 03:29:26.994+0200 E/watchface-app(  935): watchface.cpp: OnAppTimeTick(744) > 
06-25 03:29:26.994+0200 I/watchface-viewer(  935): viewer-part-resource-evas.cpp: CreateTextImage(807) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=center ']
06-25 03:29:26.994+0200 I/watchface-viewer(  935): viewer-part-resource-evas.cpp: CreateTextImage(821) > formatted size 277x63
06-25 03:29:26.999+0200 I/watchface-viewer(  935): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(577) > ImagesLoadingDoneSignal().Emit()
06-25 03:29:27.014+0200 I/AUL     (17384): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
06-25 03:29:27.114+0200 I/AUL     (14081): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-25 03:29:27.129+0200 I/efl-extension(17373): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-25 03:29:27.129+0200 I/efl-extension(  840): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-25 03:29:27.129+0200 I/efl-extension(  840): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x46070c68, elm_box, time_stamp : 15998313
06-25 03:29:27.129+0200 I/wnotib  (  840): w-notification-board-broker-main.c: _wnotib_rotary_cb(559) > Pass rotary event to home.
06-25 03:29:27.129+0200 W/W_HOME  (  840): home_navigation.c: _rotary_cb(1168) > Detent detected, obj[0x46056f58], direction[0]
06-25 03:29:27.129+0200 I/efl-extension(13314): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-25 03:29:27.129+0200 I/efl-extension(13400): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-25 03:29:27.134+0200 I/efl-extension( 1583): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-25 03:29:27.149+0200 I/WSM     ( 1178): WSM_I [Run, line = 118, thread  = 418b7460] Read request from client. 
06-25 03:29:27.149+0200 I/WSM     ( 1178): WSM_I [Run] Request len 406c 
06-25 03:29:27.149+0200 I/WSM     ( 1178): WSM_D [Run] Request data  =  [len=16492] 10f6324080030000558ffb35f1eec3e41dab72ea01abd495d47337df1c13df97f2561227abaf1f63b3e830ce464a041f457fbf84bb62542b3a4c3e6b04600444efe935f9db0a9a76b0917fa754b60c53c8ccc0769e994d14684edda6084126e547e446b4d3492ebfe5c21afaf1fb925d8acd655792c96bf77eb7b2df21831c3d455f5bc8aafdef81339708e0c89ec6a1bc625d6689daa49098154adf4f6d0318ca431acfa001dd346c22f5e902e7906184ada9c6b8a28cf62f4c32674cf43ce58cffe87a6915bbbb90a4cd740194caa57fcc82a00f527ecf75480cf97636f7ce3bf6d92cf7e1646e98a191af4368170bf2d1e85bc8727126b636a0dac5f811695bde57da41703de243bf3c3ad2f4defac3f17fd69b5b2610b9cdbec79f6242e0a75629ae30c5128e168ab426479d386fa33803c66df360b285a2782bc375bab27384f2bf74629696fc09076ab2e3564b398433fa608dcf1d44fdab6ec4db8167a781ce4d3ba37e37ea24e3a5863bf8792bd0ba078ee03db873b9b4565288994d394c2e56a39131563037646190118729252a63537eef99bf93c37d4d5c6b20bfd142436f63db34a5d4c7a1634ecd624b8d1828197093c8aa1091974932722d3be5b26eb53f30c324c344e7d502e7a74be542df9038bc357aaa2978f8a3db7e04b07611f891723c4a25be1e
06-25 03:29:27.149+0200 W/W_HOME  (  840): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-25 03:29:27.149+0200 W/W_HOME  (  840): home_navigation.c: _nav_finish_timer_add(850) > add timer:1
06-25 03:29:27.149+0200 W/W_HOME  (  840): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
06-25 03:29:27.154+0200 W/W_HOME  (  840): home_navigation.c: _is_rightedge(187) > (4320 360) not right edge: 0 0 0x46a0a4e8 -> 360 0 0x46a1d5c8
06-25 03:29:27.154+0200 E/EFL     (  840): edje<840> edje_util.c:3785 edje_object_size_min_restricted_calc() group page has a non-fixed part 'bg'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-25 03:29:27.154+0200 E/EFL     (  840): edje<840> edje_util.c:3785 edje_object_size_min_restricted_calc() group page has a non-fixed part 'bg'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-25 03:29:27.154+0200 E/EFL     (  840): edje<840> edje_util.c:3788 edje_object_size_min_restricted_calc() group page overflowed 4000x4000 with minimum size of 4320x360. Continuing discarding faulty parts.
06-25 03:29:27.154+0200 I/WSM     ( 1178): WSM_I [Run, line = 150] Send reply to client.
06-25 03:29:27.154+0200 I/WSM     ( 1178): WSM_D [Run] Send reply =  [len=16492] 0100000080030000595ebb3ff1eec3e41dab72ea01abd495d47337df1c13df97f2561227abaf1f63b3e830ce464a041f457fbf84bb62542b3a4c3e6b04600444efe935f9db0a9a76b0917fa754b60c53c8ccc0769e994d14684edda6084126e547e446b4d3492ebfe5c21afaf1fb925d8acd655792c96bf77eb7b2df21831c3d455f5bc8aafdef81339708e0c89ec6a1bc625d6689daa49098154adf4f6d0318ca431acfa001dd346c22f5e902e7906184ada9c6b8a28cf62f4c32674cf43ce58cffe87a6915bbbb90a4cd740194caa57fcc82a00f527ecf75480cf97636f7ce3bf6d92cf7e1646e98a191af4368170bf2d1e85bc8727126b636a0dac5f811695bde57da41703de243bf3c3ad2f4defac3f17fd69b5b2610b9cdbec79f6242e0a75629ae30c5128e168ab426479d386fa33803c66df360b285a2782bc375bab27384f2bf74629696fc09076ab2e3564b398433fa608dcf1d44fdab6ec4db8167a781ce4d3ba37e37ea24e3a5863bf8792bd0ba078ee03db873b9b4565288994d394c2e56a39131563037646190118729252a63537eef99bf93c37d4d5c6b20bfd142436f63db34a5d4c7a1634ecd624b8d1828197093c8aa1091974932722d3be5b26eb53f30c324c344e7d502e7a74be542df9038bc357aaa2978f8a3db7e04b07611f891723c4a25be1e274
06-25 03:29:27.164+0200 E/WMS     (  514): wms_event_handler.c: wms_event_handler_routine(24432) > 
06-25 03:29:27.164+0200 E/WMS     (  514): ==========
06-25 03:29:27.164+0200 E/WMS     (  514): ##WMS RECEIVED : mgr_host_status_res
06-25 03:29:27.164+0200 E/WMS     (  514): ==========
06-25 03:29:27.164+0200 E/WMS     (  514): wms_event_handler.c: handle_mgr_host_status_res(17032) > type : sync
06-25 03:29:27.164+0200 E/WMS     (  514): wms_event_handler.c: handle_mgr_host_status_res(17035) > preinstalled: true
06-25 03:29:27.169+0200 E/WMS     (  514): wms_msg_broker.c: wms_msg_broker_send(1825) > 
06-25 03:29:27.169+0200 E/WMS     (  514): ==========
06-25 03:29:27.169+0200 E/WMS     (  514): ##WMS SEND : mgr_status_exchange_done
06-25 03:29:27.169+0200 E/WMS     (  514): ==========
06-25 03:29:27.169+0200 E/WMS     (  514): wms_msg_broker.c: wms_msg_broker_send(1841) > Data size: 73 MAX Buffer Size: 61440
06-25 03:29:27.169+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(633) > [0x46056f58 : elm_scroller] rotary callabck is called.
06-25 03:29:27.169+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(663) > [0x46056f58 : elm_scroller] block(2)
06-25 03:29:27.169+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(664) > [0x46056f58 : elm_scroller] scroll_locked_x(0), scroll_locked_y(0)
06-25 03:29:27.169+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(665) > [0x46056f58 : elm_scroller] content size (w, h)(9360, 360)
06-25 03:29:27.169+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(666) > [0x46056f58 : elm_scroller] viewport size (w, h)(360, 360)
06-25 03:29:27.169+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(730) > [0x46056f58 : elm_scroller] CurrentPage(12) DetentValue(1)
06-25 03:29:27.169+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(731) > [0x46056f58 : elm_scroller] DetentCount(0)
06-25 03:29:27.169+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(407) > [0x46056f58 : elm_scroller] mx(9000), my(0), minx(0), miny(0), px(4320), py(0)
06-25 03:29:27.169+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(407) > [0x46056f58 : elm_scroller] mx(9000), my(0), minx(0), miny(0), px(4320), py(0)
06-25 03:29:27.169+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(407) > [0x46056f58 : elm_scroller] mx(9000), my(0), minx(0), miny(0), px(4320), py(0)
06-25 03:29:27.169+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(763) > [0x46056f58 : elm_scroller] bring in 13 page
06-25 03:29:27.169+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:5560 _elm_scroll_page_bring_in() [0x46056f58 : elm_scroller] pagenumber_h(13), pagenumber_v(0)
06-25 03:29:27.169+0200 E/WMS     (  514): wms_status_manager.c: wms_status_manager_get_device_status(875) > Host device vendor: samsung
06-25 03:29:27.169+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x46056f58 : elm_scroller] mx(9000), my(0), minx(0), miny(0), px(4320), py(0)
06-25 03:29:27.169+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x46056f58 : elm_scroller] cw(9360), ch(360), pw(360), ph(360)
06-25 03:29:27.169+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:1965 _elm_scroll_content_region_show_internal() [0x46056f58 : elm_scroller] x(4680), y(0), nx(4680), px(4320), ny(0) py(0)
06-25 03:29:27.169+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:1991 _elm_scroll_content_region_show_internal() [0x46056f58 : elm_scroller] x(4680), y(0)
06-25 03:29:27.169+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:5578 _elm_scroll_page_bring_in() [0x46056f58 : elm_scroller] _elm_scroll_content_region_show_internal() return TRUE!! x(4680), y(0)
06-25 03:29:27.169+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2676 _elm_scroll_scroll_to_x() [0x46056f58 : elm_scroller] t_in(0,270000), pos_x(4680)
06-25 03:29:27.169+0200 W/W_HOME  (  840): home_navigation.c: _anim_start_cb(1290) > anim start
06-25 03:29:27.169+0200 W/W_HOME  (  840): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-25 03:29:27.174+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2629 _elm_scroll_scroll_to_y() [0x46056f58 : elm_scroller] t_in(0,270000), pos_y(0)
06-25 03:29:27.174+0200 W/W_HOME  (  840): event_manager.c: _home_scroll_cb(585) > scroll,will,start
06-25 03:29:27.174+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 2, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 03:29:27.174+0200 W/W_HOME  (  840): event_manager.c: _home_scroll_cb(585) > scroll,start
06-25 03:29:27.174+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 3, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 03:29:27.184+0200 E/WMS     (  514): wms_status_manager.c: wms_status_manager_get_device_status(880) > Host device salescode: XEF
06-25 03:29:27.184+0200 E/wnoti-service( 1181): wnoti-sap-client.c: _get_vendor_cb(3568) > vendor : samsung, vendor_type : 0
06-25 03:29:27.189+0200 W/APP_SHORTCUT_WIDGET(  993): main.c: _vendor_changed_cb(446) >  vendor : samsung
06-25 03:29:27.204+0200 E/WMS     (  514): wms_status_manager.c: wms_status_manager_get_device_status(890) > host mcc [208], mnc [15]
06-25 03:29:27.204+0200 E/WMS     (  514): wms_xml_util.c: wms_xml_util_get_nodeset(62) > No result
06-25 03:29:27.224+0200 E/WMS     (  514): wms_status_manager.c: wms_status_manager_sync_host_status(1249) > host platform version: 6.0.1
06-25 03:29:27.234+0200 E/WMS     (  514): wms_status_manager.c: wms_status_manager_sync_host_status(1286) > vendor[samsung:samsungMass] matches. app[com.samsung.wemail]
06-25 03:29:27.244+0200 E/WMS     (  514): wms_status_manager.c: wms_status_manager_sync_host_status(1437) > Host telephony feature is supported - enable call app
06-25 03:29:27.269+0200 I/AUL     (14081): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-25 03:29:27.269+0200 E/AUL     (14081): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
06-25 03:29:27.269+0200 E/AUL     (14081): aul_path.c: __get_path(169) > root_path is NULL!
06-25 03:29:27.279+0200 W/WRT_PLUGINS/TIZEN(17384): SystemInfoCpu.cpp: fetchLoad(76) > Cannot calculate cpu load, previous value returned
06-25 03:29:27.309+0200 E/WMS     (  514): wms_status_manager.c: wms_status_manager_sync_host_status(1489) > vendor[ samsung ], support.email.sync[ true ]
06-25 03:29:27.324+0200 E/PKGMGR  (  514): pkgmgr.c: pkgmgr_client_enable(2552) > enable pkg[com.samsung.call] start
06-25 03:29:27.459+0200 I/capability-manager(14172): capability_manager_util.c: is_file_exist(120) > File /opt/usr/share/wms/HostStatus.xml Exists
06-25 03:29:27.459+0200 I/capability-manager(14172): capability_manager_xml.c: capability_manager_xml_util_get_device_info(114) > capability_manager_xml_util_get_device_info() called.
06-25 03:29:27.469+0200 W/APPS    (  840): apps_main.c: apps_main_is_hide_message(1387) >  isHide[0]
06-25 03:29:27.469+0200 W/wnotib  (  840): w-notification-board-broker-main.c: _wnotib_wms_host_status_vendor_changed_cb(329) > vendor: samsung.
06-25 03:29:27.469+0200 I/wnotib  (  840): w-notification-board-empty-panel.c: _wnb_empty_panel_message_receive(59) > type: 24
06-25 03:29:27.494+0200 I/wnotib  (  840): w-notification-board-empty-panel.c: _wnb_ep_set_texts(346) > is_connected_vendor_LO: 0, is_standalone_mode: 0
06-25 03:29:27.509+0200 E/TIZEN_N_SYSTEM_SETTINGS(  840): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
06-25 03:29:27.509+0200 E/TIZEN_N_SYSTEM_SETTINGS(  840): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-25 03:29:27.509+0200 E/TIZEN_N_SYSTEM_SETTINGS(  840): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
06-25 03:29:27.509+0200 E/TIZEN_N_SYSTEM_SETTINGS(  840): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
06-25 03:29:27.574+0200 W/W_HOME  (  840): clock_view_indicator.c: _view_remove_by_type(267) > removed:3
06-25 03:29:27.574+0200 W/W_HOME  (  840): clock_indicator.c: clock_indicator_pop(364) > icon:3(0) is popped from clock indicator
06-25 03:29:27.574+0200 W/W_HOME  (  840): cfwd.c: cfwd_get_icon_status(362) > 
06-25 03:29:27.574+0200 W/W_HOME  (  840): ============================
06-25 03:29:27.574+0200 W/W_HOME  (  840): multi_sim_category:0
06-25 03:29:27.574+0200 W/W_HOME  (  840): multi_sim_model:0
06-25 03:29:27.574+0200 W/W_HOME  (  840): support_callforward_auto:0
06-25 03:29:27.574+0200 W/W_HOME  (  840): conn_status:1
06-25 03:29:27.574+0200 W/W_HOME  (  840): remote_call_forward_auto:0
06-25 03:29:27.574+0200 W/W_HOME  (  840): auto_call_forward_status:0
06-25 03:29:27.574+0200 W/W_HOME  (  840): support_callforward_reverse:0
06-25 03:29:27.574+0200 W/W_HOME  (  840): reverse_call_forward_auto:0
06-25 03:29:27.574+0200 W/W_HOME  (  840): fwd_type:
06-25 03:29:27.574+0200 W/W_HOME  (  840): ============================
06-25 03:29:27.574+0200 W/W_HOME  (  840): 
06-25 03:29:27.574+0200 W/W_HOME  (  840): clock_view_indicator.c: _view_call_fw_icon(136) > call fwd status:0
06-25 03:29:27.574+0200 W/W_HOME  (  840): index.c: index_show(299) > is_paused:0 show VI:1 visibility:1 vi:(nil)
06-25 03:29:27.574+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] time(0,577237)
06-25 03:29:27.579+0200 W/W_HOME  (  840): event_manager.c: _clock_view_obscured_cb(651) > state: 1 -> 0
06-25 03:29:27.579+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 3, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 03:29:27.579+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 3, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 03:29:27.579+0200 I/ELM_RPANEL(  840): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-25 03:29:27.579+0200 I/ELM_RPANEL(  840): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-25 03:29:27.584+0200 W/W_INDICATOR(  756): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
06-25 03:29:27.584+0200 W/W_INDICATOR(  756): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-25 03:29:27.594+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_CANCEL : px(4680), py(0)
06-25 03:29:27.594+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] time(0,577237)
06-25 03:29:27.594+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] animation stop!!
06-25 03:29:27.594+0200 W/wnotib  (  840): w-notification-board-panel-manager.c: _wnb_pm_anim_stop_cb(96) > notiboard scroller anim stop [4680][0][360][360]
06-25 03:29:27.594+0200 W/wnotib  (  840): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(969) > No postponed update with is_for_VI: 1.
06-25 03:29:27.594+0200 W/W_HOME  (  840): home_navigation.c: _anim_stop_cb(1316) > anim stop
06-25 03:29:27.594+0200 W/W_HOME  (  840): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-25 03:29:27.594+0200 W/W_HOME  (  840): home_navigation.c: _nav_finish_timer_add(850) > add timer:1
06-25 03:29:27.594+0200 W/W_HOME  (  840): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
06-25 03:29:27.594+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(489) > [0x46056f58 : elm_scroller] detent_count(1)
06-25 03:29:27.594+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(490) > [0x46056f58 : elm_scroller] pagenumber_v(0), pagenumber_h(13)
06-25 03:29:27.594+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(512) > [0x46056f58 : elm_scroller] CurrentPage(13)
06-25 03:29:27.594+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_CANCEL : px(4680), py(0)
06-25 03:29:27.629+0200 W/WATCH_CORE(  935): appcore-watch.c: __widget_pause(1113) > widget_pause
06-25 03:29:27.629+0200 W/AUL     (  935): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.watchface.TacticalSentry) pid(935) status(bg) type(watchapp)
06-25 03:29:27.629+0200 E/watchface-app(  935): watchface.cpp: OnAppPause(717) > 
06-25 03:29:27.659+0200 I/CAPI_WIDGET_APPLICATION(  993): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
06-25 03:29:27.659+0200 W/AUL     (  993): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.app-widget.widget) pid(993) status(fg) type(widgetapp)
06-25 03:29:27.659+0200 I/CAPI_WIDGET_APPLICATION(  993): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
06-25 03:29:27.734+0200 E/W_HOME  (  840): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
06-25 03:29:27.734+0200 E/EFL     (  840): edje<840> edje_util.c:3785 edje_object_size_min_restricted_calc() group page has a non-fixed part 'bg'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-25 03:29:27.734+0200 E/EFL     (  840): edje<840> edje_util.c:3785 edje_object_size_min_restricted_calc() group page has a non-fixed part 'bg'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-25 03:29:27.734+0200 E/EFL     (  840): edje<840> edje_util.c:3788 edje_object_size_min_restricted_calc() group page overflowed 4000x4000 with minimum size of 4320x360. Continuing discarding faulty parts.
06-25 03:29:27.759+0200 W/W_HOME  (  840): event_manager.c: _home_scroll_cb(585) > scroll,will,done
06-25 03:29:27.759+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 03:29:27.759+0200 W/W_HOME  (  840): event_manager.c: _home_scroll_cb(585) > scroll,done
06-25 03:29:27.759+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 03:29:27.779+0200 E/PKGMGR_SERVER(14173): pkgmgr-server.c: main(2242) > package manager server start
06-25 03:29:27.979+0200 E/PKGMGR  (  514): pkgmgr.c: pkgmgr_client_enable(2638) > enable pkg finish, ret=[0]
06-25 03:29:27.979+0200 E/PKGMGR  (  514): pkgmgr.c: pkgmgr_client_disable(2645) > disable pkg[] start
06-25 03:29:27.994+0200 E/PKGMGR_SERVER(14177): pkgmgr-server.c: queue_job(1981) > ENABLE_PKG start, pkgid=[com.samsung.call]
06-25 03:29:28.009+0200 E/PKGMGR_SERVER(14178): pkgmgr-server.c: queue_job(1990) > DISABLE_PKG start, pkgid=[]
06-25 03:29:28.009+0200 E/PKGMGR  (  514): pkgmgr.c: pkgmgr_client_disable(2731) > disable pkg finish, ret=[0]
06-25 03:29:28.024+0200 E/CAPI_TELEPHONY(  514): telephony_common.c: telephony_init(358) > telephony feature is disabled
06-25 03:29:28.099+0200 W/W_HOME  (  840): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
06-25 03:29:28.279+0200 W/WRT_PLUGINS/TIZEN(17384): SystemInfoCpu.cpp: fetchLoad(76) > Cannot calculate cpu load, previous value returned
06-25 03:29:28.304+0200 E/PKGMGR_STATE(14178): pkg_state.c: __pkg_state_disable_pkg(420) > start disable_pkg : pkgid = 
06-25 03:29:28.364+0200 E/PKGMGR_STATE(14177): pkg_state.c: __pkg_state_enable_pkg(339) > start enable_pkg : pkgid = com.samsung.call
06-25 03:29:28.404+0200 E/PKGMGR_STATE(14177): pkg_state.c: __make_filtered_pkgid_list(317) > pkgid[com.samsung.call] is decided not to broadcast.
06-25 03:29:28.404+0200 E/PKGMGR_STATE(14177): pkg_state.c: __pkg_state_enable_pkg(350) > nothing to broadcast.
06-25 03:29:28.414+0200 E/PKGMGR_INFO(  514): pkgmgrinfo_private.c: __db_busy_handler(248) > __db_busy_handler(count=0) is called. pid=[514]
06-25 03:29:28.414+0200 E/PKGMGR_SERVER(14173): pkgmgr-server.c: sighandler(486) > child NORMAL exit [14177]
06-25 03:29:28.429+0200 I/UXT     (14081): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
06-25 03:29:28.434+0200 E/PKGMGR_INFO(  514): pkgmgrinfo_private.c: __db_busy_handler(248) > __db_busy_handler(count=1) is called. pid=[514]
06-25 03:29:28.439+0200 E/PKGMGR_INFO( 1355): pkgmgrinfo_private.c: __db_busy_handler(248) > __db_busy_handler(count=0) is called. pid=[1355]
06-25 03:29:28.454+0200 E/PKGMGR_INFO(  514): pkgmgrinfo_private.c: __db_busy_handler(248) > __db_busy_handler(count=2) is called. pid=[514]
06-25 03:29:28.474+0200 E/PKGMGR_INFO(  514): pkgmgrinfo_private.c: __db_busy_handler(248) > __db_busy_handler(count=3) is called. pid=[514]
06-25 03:29:28.494+0200 E/PKGMGR_STATE(14178): pkg_state.c: __exec_db_query(82) > Sqlite3 error [1] : <near " ": syntax error> preparing <update package_changeable_info set package_disable='true' where > query
06-25 03:29:28.494+0200 E/PKGMGR_STATE(14178): pkg_state.c: __update_pkg_info_for_disable(135) > __exec_db_query() failed.
06-25 03:29:28.494+0200 E/PKGMGR_STATE(14178): pkg_state.c: __pkg_state_disable_pkg(456) > __update_pkg_info_for_disable() failed.
06-25 03:29:28.494+0200 E/PKGMGR_STATE(14178): pkg_state.c: __pkg_state_disable_pkg(483) > disable broadcast_pkgid_list : ::
06-25 03:29:28.514+0200 E/PKGMGR_SERVER(14173): pkgmgr-server.c: sighandler(486) > child NORMAL exit [14178]
06-25 03:29:28.554+0200 E/EFL     (  840): ecore_x<840> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=15999732 button=1
06-25 03:29:28.554+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056f58 : elm_scroller] mouse move
06-25 03:29:28.559+0200 W/W_HOME  (  840): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-25 03:29:28.559+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056f58 : elm_scroller] mouse move
06-25 03:29:28.559+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056f58 : elm_scroller] hold(0), freeze(0)
06-25 03:29:28.569+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056f58 : elm_scroller] mouse move
06-25 03:29:28.569+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056f58 : elm_scroller] hold(0), freeze(0)
06-25 03:29:28.579+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056f58 : elm_scroller] mouse move
06-25 03:29:28.579+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056f58 : elm_scroller] hold(0), freeze(0)
06-25 03:29:28.589+0200 E/EFL     (  993): evas_main<993> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
06-25 03:29:28.589+0200 E/EFL     (  993): evas_main<993> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
06-25 03:29:28.589+0200 E/EFL     (  993): evas_main<993> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
06-25 03:29:28.589+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056f58 : elm_scroller] mouse move
06-25 03:29:28.589+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056f58 : elm_scroller] hold(0), freeze(0)
06-25 03:29:28.599+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056f58 : elm_scroller] mouse move
06-25 03:29:28.599+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056f58 : elm_scroller] hold(0), freeze(0)
06-25 03:29:28.624+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056f58 : elm_scroller] mouse move
06-25 03:29:28.624+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056f58 : elm_scroller] hold(0), freeze(0)
06-25 03:29:28.624+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056f58 : elm_scroller] mouse move
06-25 03:29:28.624+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056f58 : elm_scroller] hold(0), freeze(0)
06-25 03:29:28.644+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056f58 : elm_scroller] mouse move
06-25 03:29:28.644+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056f58 : elm_scroller] hold(0), freeze(0)
06-25 03:29:28.659+0200 E/EFL     (  840): ecore_x<840> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=15999843 button=1
06-25 03:29:28.659+0200 W/W_HOME  (  840): home_navigation.c: _up_cb(1247) > up
06-25 03:29:28.659+0200 W/W_HOME  (  840): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-25 03:29:28.659+0200 W/W_HOME  (  840): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
06-25 03:29:28.679+0200 W/AUL     (  993): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.scorekeeperforgear)
06-25 03:29:28.679+0200 W/AUL_AMD (  506): amd_request.c: __request_handler(669) > __request_handler: 0
06-25 03:29:28.679+0200 W/AUL_AMD (  506): amd_launch.c: _start_app(1782) > caller pid : 993
06-25 03:29:28.679+0200 I/AUL_AMD (  506): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
06-25 03:29:28.694+0200 E/RESOURCED(  598): block.c: block_prelaunch_state(138) > insert data org.example.scorekeeperforgear, table num : 7
06-25 03:29:28.699+0200 W/AUL_AMD (  506): amd_launch.c: _start_app(2218) > pad pid(-5)
06-25 03:29:28.699+0200 W/AUL_PAD ( 1356): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
06-25 03:29:28.699+0200 W/AUL_PAD ( 1356): launchpad.c: __send_result_to_caller(272) > Check app launching
06-25 03:29:28.699+0200 W/AUL_PAD (14147): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
06-25 03:29:28.699+0200 W/AUL_PAD (14147): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
06-25 03:29:28.699+0200 W/AUL_PAD (14147): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
06-25 03:29:28.699+0200 W/AUL_PAD (14147): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.scorekeeperforgear)
06-25 03:29:28.794+0200 I/efl-extension(14147): efl_extension.c: eext_mod_init(40) > Init
06-25 03:29:28.799+0200 I/UXT     (14147): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
06-25 03:29:28.824+0200 W/AUL_PAD (14147): launchpad_loader.c: main(690) > [candidate] dlsym
06-25 03:29:28.824+0200 W/AUL_PAD (14147): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.scorekeeperforgear)
06-25 03:29:28.844+0200 I/CAPI_APPFW_APPLICATION(14147): app_main.c: ui_app_main(704) > app_efl_main
06-25 03:29:28.859+0200 I/CAPI_APPFW_APPLICATION(14147): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
06-25 03:29:28.899+0200 W/AUL     (  506): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.scorekeeperforgear) pid(14147) type(uiapp) bg(2)
06-25 03:29:28.899+0200 W/AUL_AMD (  506): amd_status.c: __socket_monitor_cb(1277) > (14147) was created
06-25 03:29:28.899+0200 E/AUL     (  506): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
06-25 03:29:28.899+0200 W/AUL     (  993): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14147)
06-25 03:29:28.904+0200 E/APP_SHORTCUT_WIDGET(  993): main.c: _tts_button_mouse_clicked_cb(732) >  (tts_status == 0) -> _tts_button_mouse_clicked_cb() return
06-25 03:29:28.934+0200 W/STARTER (  755): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [14147]
06-25 03:29:29.039+0200 I/efl-extension(14147): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1242) > Put the surface[0x437f1880]'s widget[0x437ea250] to elm_conformant widget[0x41a91150]
06-25 03:29:29.044+0200 I/efl-extension(14147): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
06-25 03:29:29.044+0200 I/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_add(1990) > called!!
06-25 03:29:29.059+0200 I/efl-extension(14147): efl_extension_rotary_selector.c: _eext_rotary_selector_data_init(586) > rsd is initialized!!
06-25 03:29:29.099+0200 I/efl-extension(14147): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
06-25 03:29:29.099+0200 I/efl-extension(14147): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
06-25 03:29:29.099+0200 I/efl-extension(14147): efl_extension_rotary.c: _init_Xi2_system(314) > In
06-25 03:29:29.099+0200 I/efl-extension(14147): efl_extension_rotary.c: _init_Xi2_system(375) > Done
06-25 03:29:29.099+0200 I/efl-extension(14147): efl_extension_rotary_selector.c: _event_area_callback_add(500) > called!!
06-25 03:29:29.099+0200 I/efl-extension(14147): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x437eb568, elm_layout, _activated_obj : 0x0, activated : 1
06-25 03:29:29.099+0200 I/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 03:29:29.119+0200 I/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 03:29:29.119+0200 I/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 03:29:29.119+0200 E/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 03:29:29.119+0200 I/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 03:29:29.119+0200 I/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 03:29:29.119+0200 I/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 03:29:29.119+0200 E/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 03:29:29.119+0200 I/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 03:29:29.124+0200 I/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 03:29:29.124+0200 I/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 03:29:29.124+0200 E/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 03:29:29.124+0200 I/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 03:29:29.129+0200 I/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 03:29:29.129+0200 I/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 03:29:29.129+0200 E/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 03:29:29.129+0200 I/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 03:29:29.139+0200 I/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 03:29:29.139+0200 I/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 03:29:29.139+0200 E/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 03:29:29.139+0200 I/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 03:29:29.144+0200 I/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 03:29:29.144+0200 I/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 03:29:29.144+0200 E/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 03:29:29.144+0200 I/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 03:29:29.149+0200 I/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 03:29:29.149+0200 I/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 03:29:29.149+0200 E/efl-extension(14147): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 03:29:29.149+0200 E/EFL     (14147): elementary<14147> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
06-25 03:29:29.154+0200 E/EFL     (14147): elementary<14147> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44540ae0) will be pushed
06-25 03:29:29.159+0200 W/W_HOME  (  840): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
06-25 03:29:29.169+0200 I/efl-extension(14147): efl_extension_rotary_selector.c: _rotary_selector_show_cb(805) > called!!
06-25 03:29:29.174+0200 I/efl-extension(14147): efl_extension_rotary_selector.c: _rotary_selector_move_cb(776) > called!!
06-25 03:29:29.194+0200 E/WMS     (  514): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(505) > telephony : 0
06-25 03:29:29.194+0200 E/WMS     (  514): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(506) > wifi : 1
06-25 03:29:29.194+0200 E/WMS     (  514): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(510) > scs : true
06-25 03:29:29.214+0200 E/WMS     (  514): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(526) > svoice not disabled
06-25 03:29:29.214+0200 E/PKGMGR_INFO(  514): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_destroy_pkginfo(1915) > (handle == NULL) pkginfo handle is NULL
06-25 03:29:29.229+0200 W/W_HOME  (  840): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
06-25 03:29:29.229+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 03:29:29.229+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 03:29:29.234+0200 E/WMS     (  514): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(545) > camera : 0
06-25 03:29:29.239+0200 E/WMS     (  514): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(560) > wps : 1
06-25 03:29:29.244+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 03:29:29.244+0200 W/W_HOME  (  840): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
06-25 03:29:29.244+0200 I/APP_CORE(14147): appcore-efl.c: __do_app(453) > [APP 14147] Event: RESET State: CREATED
06-25 03:29:29.244+0200 I/CAPI_APPFW_APPLICATION(14147): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
06-25 03:29:29.249+0200 E/WMS     (  514): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(566) > speaker : 0
06-25 03:29:29.254+0200 I/APP_CORE(14147): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
06-25 03:29:29.254+0200 I/APP_CORE(14147): appcore-efl.c: __do_app(524) > [APP 14147] Initial Launching, call the resume_cb
06-25 03:29:29.254+0200 I/CAPI_APPFW_APPLICATION(14147): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
06-25 03:29:29.259+0200 W/W_INDICATOR(  756): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
06-25 03:29:29.259+0200 W/W_INDICATOR(  756): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-25 03:29:29.264+0200 E/WMS     (  514): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(572) > width : 360
06-25 03:29:29.269+0200 E/WMS     (  514): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(578) > height : 360
06-25 03:29:29.279+0200 W/WRT_PLUGINS/TIZEN(17384): SystemInfoCpu.cpp: fetchLoad(76) > Cannot calculate cpu load, previous value returned
06-25 03:29:29.284+0200 E/WMS     (  514): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(584) > barometer : 1
06-25 03:29:29.289+0200 E/WMS     (  514): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(590) > magnetometer : 0
06-25 03:29:29.309+0200 E/WMS     (  514): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(596) > photometer : 1
06-25 03:29:29.324+0200 E/WMS     (  514): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(602) > heartrate : 1
06-25 03:29:29.329+0200 E/WMS     (  514): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(608) > ultraviolet : 0
06-25 03:29:29.344+0200 E/WMS     (  514): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(614) > irled : 0
06-25 03:29:29.349+0200 E/WMS     (  514): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(691) > push : 1
06-25 03:29:29.349+0200 E/WMS     (  514): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(702) > auto connection : true
06-25 03:29:29.404+0200 E/PKGMGR_INFO(  514): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_destroy_pkginfo(1915) > (handle == NULL) pkginfo handle is NULL
06-25 03:29:29.429+0200 E/WMS     (  514): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(775) > support hfp : 0
06-25 03:29:29.444+0200 E/WMS     (  514): wms_msg_broker.c: wms_msg_broker_send(1825) > 
06-25 03:29:29.444+0200 E/WMS     (  514): ==========
06-25 03:29:29.444+0200 E/WMS     (  514): ##WMS SEND : mgr_wearable_status_res
06-25 03:29:29.444+0200 E/WMS     (  514): ==========
06-25 03:29:29.444+0200 E/WMS     (  514): wms_msg_broker.c: wms_msg_broker_send(1841) > Data size: 19901 MAX Buffer Size: 61440
06-25 03:29:29.444+0200 E/WMS     (  514): wms_event_handler.c: handle_mgr_host_status_res(17067) > need full check 0
06-25 03:29:29.444+0200 E/WMS     (  514): wms_event_handler.c: handle_mgr_host_status_res(17069) > isFirstConnect[0], is_full_sync[0]
06-25 03:29:29.444+0200 E/WMS     (  514): wms_event_handler.c: _wms_event_handler_signal_to_systemd(1211) > wmanager_connected value is already true. but rewrite.
06-25 03:29:29.444+0200 E/wnoti-ancs( 1181): wnoti-ancs.c: wnoti_ancs_ios_connected_status(2707) > pre_connect_status : 0, bap_connected_status : 0
06-25 03:29:29.444+0200 W/WPROXY  ( 1157): net-device.c: __connection_changed_cb(163) > WMS:[1], SAP:[0x1], BAP:[0]
06-25 03:29:29.444+0200 W/WPROXY  ( 1157): net-device.c: __connection_changed_cb(166) > [Ignore] Any connection status is not changed.
06-25 03:29:29.444+0200 W/MC_CONSUMER( 1257): wmc-service-consumer.c: _wms_connection_changed_callback(449) > [33m WMS Connected, g_eServiceConnectState = 3[0m
06-25 03:29:29.444+0200 W/MUSIC_CONTROL_SERVICE( 1257): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:1257]   msg [WMC_SERVICE_WIPC_MSG_ID_CONNECTION_CHANGED][0m
06-25 03:29:29.444+0200 W/MUSIC_CONTROL_SERVICE( 1257): music-control-consumer-control.c: music_control_consumer_msg_process(241) > [33m[TID:1257]   Device State [0] normal:0 dim:1 off:2[0m
06-25 03:29:29.444+0200 W/MUSIC_CONTROL_SERVICE( 1257): music-control-consumer-control.c: music_control_consumer_msg_process(341) > [33m[TID:1257]   connection state = 1[0m
06-25 03:29:29.449+0200 E/W_HOME  (  840): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
06-25 03:29:29.449+0200 W/W_HOME  (  840): clock_event.c: _wmanager_connectivity_get(397) > network status : 0
06-25 03:29:29.449+0200 W/W_HOME  (  840): clock_event.c: _wmanager_connectivity_get(402) > sap_connected : 1
06-25 03:29:29.449+0200 W/W_HOME  (  840): clock_event.c: _wmanager_connectivity_get(408) > sap connectivity type : 1
06-25 03:29:29.449+0200 W/W_HOME  (  840): clock_event.c: _wmanager_connectivity_get(414) > network status : 3
06-25 03:29:29.449+0200 W/W_HOME  (  840): clock_event.c: _wmanager_connectivity_get(428) > scs login : 0
06-25 03:29:29.449+0200 W/WECONN  (  499): <__wc_feature_wms_connected_cb:438> priv->wms_connected = 1
06-25 03:29:29.449+0200 E/WMS     (  514): wms_event_handler.c: _wms_event_handler_signal_to_systemd(1213) > 
06-25 03:29:29.449+0200 E/WMS     (  514): ==========
06-25 03:29:29.449+0200 E/WMS     (  514): ##WMS WMANAGER CONNECTED : TRUE
06-25 03:29:29.449+0200 E/WMS     (  514): ==========
06-25 03:29:29.449+0200 W/W_HOME  (  840): clock_event.c: _wmanager_connectivity_get(470) > connected via bluetooth
06-25 03:29:29.449+0200 W/W_HOME  (  840): clock_view_indicator.c: _view_remove_by_type(267) > removed:4
06-25 03:29:29.449+0200 W/W_HOME  (  840): clock_indicator.c: clock_indicator_pop(364) > icon:5(0) is popped from clock indicator
06-25 03:29:29.449+0200 W/wnotib  (  840): w-notification-board-broker-main.c: _wnotib_connection_state_changed_cb(374) > is_LO: 0, is_connected: 1
06-25 03:29:29.449+0200 E/wnotib  (  840): w-notification-board-noti-manager-common.c: wnb_nm_get_category_by_application_id(1192) > No category matched.
06-25 03:29:29.449+0200 W/wnotib  (  840): w-notification-board-broker-main.c: _wnotib_connection_state_changed_cb(383) > No tips notification.
06-25 03:29:29.454+0200 E/WMS     (  514): wms_event_handler.c: handle_mgr_host_status_res(17078) > TIMESTAMP saved: 1498354161072AMC;<<LB:>KP
06-25 03:29:29.454+0200 E/WMS     (  514): wms_event_handler.c: wms_event_handler_routine(24448) > [mgr_host_status_res] handler success.
06-25 03:29:29.474+0200 W/MSG_CONSUMER( 1495): SapClient.cpp: _onWmsConnectionChanged(810) > [0;35mprevious_status: (1), status: (1)[0;m
06-25 03:29:29.474+0200 W/MSG_CONSUMER( 1495): SapClient.cpp: _onWmsConnectionChanged(813) > [0;35m_onWmsConnectionChanged() is ignored for same status change. prev:(1), cur:(1)[0;m
06-25 03:29:29.474+0200 I/magazine-service( 1009): magazine-service-connection.c: _magazine_service_connection_vconf_key_changed_cb(179) > host_connected changed [1] -> [1]
06-25 03:29:29.484+0200 E/WMS     (  514): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
06-25 03:29:29.484+0200 W/MUSIC_CONTROL_SERVICE( 1257): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:1257]   remote mode[1][0m
06-25 03:29:29.484+0200 W/MC_CONSUMER( 1257): wmc-service-consumer.c: wmc_service_consumer_send_data(587) > [33m {"msgId":"music-getattribute-req"}[0m
06-25 03:29:29.489+0200 E/WMS     (  514): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
06-25 03:29:29.529+0200 W/CRASH_MANAGER(14151): worker.c: worker_job(1205) > 111414773636f149835416
