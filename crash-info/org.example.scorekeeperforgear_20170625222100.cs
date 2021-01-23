S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.2
Build-Number: R732XXU2EQC1
Build-Date: 2017.03.13 20:32:41

Crash Information
Process Name: scorekeeperforgear
PID: 3677
Date: 2017-06-25 22:21:00+0200
Executable File Path: /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x60

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xbed3945c, r5   = 0x41392980
r6   = 0x00000274, r7   = 0x41392e0f
r8   = 0x4185f748, r9   = 0x00000e5d
r10  = 0x41767a58, fp   = 0x00000000
ip   = 0x40fb2140, sp   = 0xbed38c50
lr   = 0x41391bf9, pc   = 0x416b6118
cpsr = 0x60000030

Memory Information
MemTotal:   491132 KB
MemFree:     11928 KB
Buffers:     17756 KB
Cached:     133076 KB
VmPeak:     117876 KB
VmSize:     117872 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       17420 KB
VmRSS:       17420 KB
VmData:      58284 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23316 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 7
PID = 3677 TID = 3677
3677 3747 3748 3749 3750 3752 3753 

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
416cd000 416d2000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
416da000 416e6000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
416ef000 41710000 r-xp /usr/lib/libefl-extension.so.0.1.0
41718000 4171d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
4172c000 41860000 rw-p [heap]
41860000 4188a000 r-xp /usr/lib/libsensor.so.1.9.5
41893000 4189a000 r-xp /usr/lib/libctx-shared.so.0.8.3
418a2000 418a7000 r-xp /usr/lib/libctx-client.so.0.8.3
418af000 418c1000 r-xp /usr/lib/libefl-assist.so.0.1.0
418c9000 41981000 r-xp /usr/lib/libcairo.so.2.11200.14
4198c000 41996000 r-xp /usr/lib/libsensord-shared.so
4199e000 419ad000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
419b6000 419cc000 r-xp /usr/lib/libtts.so
419d5000 419f8000 r-xp /usr/lib/libui-extension.so.0.1.0
41a01000 41a0c000 r-xp /usr/lib/libtbm.so.1.0.0
41a14000 41a22000 r-xp /usr/lib/libGLESv2.so.2.0
41a2b000 41a2c000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41a35000 41a3b000 r-xp /usr/lib/libxcb-render.so.0.0.0
41a43000 41a46000 r-xp /usr/lib/libEGL.so.1.4
41a4e000 41a51000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41a59000 41a5a000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41a63000 41beb000 r-xp /usr/lib/libicui18n.so.57.1
41bfb000 41d01000 r-xp /usr/lib/libicuuc.so.57.1
41d17000 41d1f000 r-xp /usr/lib/libdrm.so.2.4.0
41d27000 41d29000 r-xp /usr/lib/libdri2.so.0.0.0
41d31000 41d37000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41d3f000 41d44000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41d4c000 41d65000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
43606000 43627000 r-xp /usr/lib/libexif.so.12.3.3
4363a000 4363c000 r-xp /usr/lib/libttrace.so.1.1
43644000 43649000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43651000 43657000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43660000 43668000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43670000 43692000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4369b000 436a2000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
436ab000 436ad000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
436b5000 436bc000 r-xp /usr/lib/libminizip.so.1.0.0
436c4000 436d1000 r-xp /usr/lib/libail.so.0.1.0
436da000 436e0000 r-xp /usr/lib/libproc-stat.so.0.2.96
436e8000 436e9000 r-xp /usr/lib/libresponse.so.0.2.96
436f1000 436f6000 r-xp /usr/lib/libsystem.so.0.0.0
43700000 437ca000 r-xp /usr/lib/libCOREGL.so.4.0
43bfc000 443fb000 rw-p [stack:3747]
443fc000 44bfb000 rw-p [stack:3748]
44bfc000 45400000 rw-p [stack:3749]
45500000 4550b000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
45515000 45d14000 rw-p [stack:3750]
45d14000 45d19000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
45d21000 45d38000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
45d45000 45d47000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45d50000 4654f000 rw-p [stack:3752]
4654f000 46550000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
46710000 472ec000 rw-p [stack:3753]
bed19000 bed3a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3677)
Call Stack Count: 18
 0: resume_viewScore() + 0xb (0x416b6118) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x4118
 1: (0x41391bf9) [/usr/lib/libcapi-appfw-application.so.0] + 0x1bf9
 2: (0x400441ed) [/usr/lib/libappcore-efl.so.1] + 0x31ed
 3: (0x413a7d1f) [/usr/lib/libappcore-common.so.1] + 0x1d1f
 4: (0x4005a495) [/usr/lib/libaul.so.0] + 0x4495
 5: (0x4005afad) [/usr/lib/libaul.so.0] + 0x4fad
 6: (0x403bbfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
 7: g_main_context_dispatch + 0xbc (0x403bd7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
 8: (0x40302ca7) [/usr/lib/libecore.so.1] + 0x10ca7
 9: (0x402fdb4f) [/usr/lib/libecore.so.1] + 0xbb4f
10: (0x402fe4d5) [/usr/lib/libecore.so.1] + 0xc4d5
11: ecore_main_loop_begin + 0x30 (0x402fe879) [/usr/lib/libecore.so.1] + 0xc879
12: appcore_efl_main + 0x332 (0x40044b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
13: ui_app_main + 0xb0 (0x41392421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
14: main + 0xc2 (0x416b576b) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x376b
15: (0x40001a53) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x1a53
16: __libc_start_main + 0x114 (0x4049485c) [/lib/libc.so.6] + 0x1785c
17: (0x40001e0c) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x1e0c
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
e(596) > photometer : 1
06-25 22:21:00.105+0200 E/WMS     (  516): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(602) > heartrate : 1
06-25 22:21:00.115+0200 E/WMS     (  516): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(608) > ultraviolet : 0
06-25 22:21:00.120+0200 E/WMS     (  516): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(614) > irled : 0
06-25 22:21:00.145+0200 E/WMS     (  516): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(691) > push : 1
06-25 22:21:00.145+0200 E/WMS     (  516): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(702) > auto connection : true
06-25 22:21:00.205+0200 E/PKGMGR_INFO(  516): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_destroy_pkginfo(1915) > (handle == NULL) pkginfo handle is NULL
06-25 22:21:00.220+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,926726)
06-25 22:21:00.220+0200 W/W_HOME  (  831): event_manager.c: _clock_view_obscured_cb(651) > state: 1 -> 0
06-25 22:21:00.220+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 3, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 22:21:00.220+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 3, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 22:21:00.220+0200 I/wnotib  (  831): w-notification-board-common.c: wnotib_common_set_panel_displayed_state(4968) > Set is_notiboard_displayed to 1.
06-25 22:21:00.225+0200 E/WMS     (  516): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(775) > support hfp : 0
06-25 22:21:00.225+0200 E/WMS     (  516): wms_msg_broker.c: wms_msg_broker_send(1825) > 
06-25 22:21:00.225+0200 E/WMS     (  516): ==========
06-25 22:21:00.225+0200 E/WMS     (  516): ##WMS SEND : mgr_wearable_status_res
06-25 22:21:00.225+0200 E/WMS     (  516): ==========
06-25 22:21:00.225+0200 E/WMS     (  516): wms_msg_broker.c: wms_msg_broker_send(1841) > Data size: 19901 MAX Buffer Size: 61440
06-25 22:21:00.240+0200 I/wnotib  (  831): w-notification-board-basic-panel.c: _wnb_basic_panel_activate(3337) > page_index: 0.
06-25 22:21:00.240+0200 W/W_HOME  (  831): noti_broker.c: _handler_indicator_select(579) > 0
06-25 22:21:00.240+0200 W/W_HOME  (  831): noti_broker.c: _handler_indicator_select(589) > select index:1
06-25 22:21:00.240+0200 E/W_HOME  (  831): page_indicator.c: page_indicator_item_at(292) > (index < 0 || index >= PAGE_INDICATOR_MAX) -> page_indicator_item_at() return
06-25 22:21:00.240+0200 W/W_HOME  (  831): noti_broker.c: _handler_indicator_show(539) > 
06-25 22:21:00.240+0200 W/W_HOME  (  831): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
06-25 22:21:00.240+0200 W/wnotib  (  831): w-notification-board-noti-manager.c: wnb_nm_control_home_indicator(59) > Hide home indicator.
06-25 22:21:00.240+0200 W/W_HOME  (  831): noti_broker.c: _handler_noti_indicator_hide(496) > 
06-25 22:21:00.240+0200 E/WMS     (  516): wms_msg_broker.c: wms_msg_broker_send(1825) > 
06-25 22:21:00.240+0200 E/WMS     (  516): ==========
06-25 22:21:00.240+0200 E/WMS     (  516): ##WMS SEND : mgr_host_status_req
06-25 22:21:00.240+0200 E/WMS     (  516): ==========
06-25 22:21:00.240+0200 E/WMS     (  516): wms_msg_broker.c: wms_msg_broker_send(1841) > Data size: 52 MAX Buffer Size: 61440
06-25 22:21:00.240+0200 E/WMS     (  516): wms_event_handler.c: handle_mgr_wearable_status_req(16911) > handle_mgr_wearable_status_req completed
06-25 22:21:00.240+0200 E/WMS     (  516): wms_event_handler.c: wms_event_handler_routine(24448) > [mgr_wearable_status_req] handler success.
06-25 22:21:00.245+0200 E/wnoti-service( 1165): wnoti-server-mgr-stub.c: __wnoti_change_new_flag_stub(3101) > change_type : 0, value : 0
06-25 22:21:00.250+0200 I/ELM_RPANEL(  831): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-25 22:21:00.260+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1106), py(0)
06-25 22:21:00.260+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,926726)
06-25 22:21:00.260+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1106), py(0)
06-25 22:21:00.260+0200 W/W_HOME  (  831): index.c: index_show(299) > is_paused:0 show VI:1 visibility:1 vi:0x4a912dc8
06-25 22:21:00.270+0200 E/WMS     (  516): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
06-25 22:21:00.280+0200 I/efl-extension( 3677): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1242) > Put the surface[0x437e4b58]'s widget[0x437f0928] to elm_conformant widget[0x454090d0]
06-25 22:21:00.285+0200 I/efl-extension( 3677): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
06-25 22:21:00.285+0200 E/WMS     (  516): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
06-25 22:21:00.310+0200 I/TIZEN_N_SOUND_MANAGER( 1422): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
06-25 22:21:00.310+0200 W/TIZEN_N_SOUND_MANAGER( 1422): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
06-25 22:21:00.310+0200 W/WAKEUP-SERVICE( 1422): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
06-25 22:21:00.310+0200 I/HIGEAR  ( 1422): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
06-25 22:21:00.310+0200 I/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_add(1990) > called!!
06-25 22:21:00.320+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1326): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
06-25 22:21:00.320+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1326): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
06-25 22:21:00.320+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1326): preference.c: preference_get_boolean(1173) > preference_get_boolean(1326) : test_healthy_pace error
06-25 22:21:00.320+0200 W/SHealthCommon( 1326): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1498348800000,000000[0;m
06-25 22:21:00.365+0200 W/WATCH_CORE(  961): appcore-watch.c: __widget_resume(1124) > widget_resume
06-25 22:21:00.365+0200 W/AUL     (  961): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.watchface.TacticalSentry) pid(961) status(fg) type(watchapp)
06-25 22:21:00.365+0200 E/watchface-app(  961): watchface.cpp: OnAppResume(725) > 
06-25 22:21:00.365+0200 I/watchface-viewer(  961): viewer-data-provider.cpp: FlushPendingChanges(2241) > notify pending [50]
06-25 22:21:00.365+0200 E/clock-component(  961): clock-component-alarm.c: _clock_component_alarm_get_lastest_alarm(176) > [0;31malarm_list is [(nil)][0;m
06-25 22:21:00.365+0200 I/watchface-viewer(  961): viewer-part-resource.cpp: Start(1276) > mState[3]
06-25 22:21:00.365+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(-1,315660)
06-25 22:21:00.365+0200 I/CAPI_WATCH_APPLICATION(  961): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-25 22:21:00.365+0200 E/watchface-app(  961): watchface.cpp: OnAppTimeTick(744) > 
06-25 22:21:00.370+0200 I/watchface-viewer(  961): viewer-part-resource-evas.cpp: CreateTextImage(807) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=center ']
06-25 22:21:00.370+0200 I/watchface-viewer(  961): viewer-part-resource-evas.cpp: CreateTextImage(821) > formatted size 37x23
06-25 22:21:00.370+0200 I/watchface-viewer(  961): viewer-part-resource-evas.cpp: CreateTextImage(807) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=center ']
06-25 22:21:00.370+0200 I/watchface-viewer(  961): viewer-part-resource-evas.cpp: CreateTextImage(821) > formatted size 280x63
06-25 22:21:00.375+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_CANCEL : px(1080), py(0)
06-25 22:21:00.375+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(-1,315660)
06-25 22:21:00.375+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] animation stop!!
06-25 22:21:00.375+0200 W/wnotib  (  831): w-notification-board-panel-manager.c: _wnb_pm_anim_stop_cb(96) > notiboard scroller anim stop [1080][0][360][360]
06-25 22:21:00.380+0200 W/wnotib  (  831): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(969) > No postponed update with is_for_VI: 1.
06-25 22:21:00.380+0200 W/W_HOME  (  831): home_navigation.c: _anim_stop_cb(1316) > anim stop
06-25 22:21:00.380+0200 W/W_HOME  (  831): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-25 22:21:00.380+0200 W/W_HOME  (  831): home_navigation.c: _nav_finish_timer_add(850) > add timer:1
06-25 22:21:00.380+0200 W/W_HOME  (  831): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
06-25 22:21:00.380+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(489) > [0x46056818 : elm_scroller] detent_count(-1)
06-25 22:21:00.380+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(490) > [0x46056818 : elm_scroller] pagenumber_v(0), pagenumber_h(3)
06-25 22:21:00.380+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(512) > [0x46056818 : elm_scroller] CurrentPage(3)
06-25 22:21:00.380+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_CANCEL : px(1080), py(0)
06-25 22:21:00.390+0200 I/watchface-viewer(  961): viewer-part-resource-evas.cpp: CreateTextImage(807) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=center ']
06-25 22:21:00.390+0200 I/watchface-viewer(  961): viewer-part-resource-evas.cpp: CreateTextImage(821) > formatted size 184x63
06-25 22:21:00.390+0200 I/watchface-viewer(  961): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(577) > ImagesLoadingDoneSignal().Emit()
06-25 22:21:00.395+0200 I/efl-extension( 3677): efl_extension_rotary_selector.c: _eext_rotary_selector_data_init(586) > rsd is initialized!!
06-25 22:21:00.410+0200 W/WATCH_CORE(  961): appcore-watch.c: __widget_pause(1113) > widget_pause
06-25 22:21:00.410+0200 W/AUL     (  961): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.watchface.TacticalSentry) pid(961) status(bg) type(watchapp)
06-25 22:21:00.410+0200 E/watchface-app(  961): watchface.cpp: OnAppPause(717) > 
06-25 22:21:00.435+0200 I/efl-extension( 1339): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
06-25 22:21:00.440+0200 I/efl-extension(  831): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
06-25 22:21:00.440+0200 I/efl-extension(  831): efl_extension_rotary.c: _rotary_rotate_handler_cb(539) > Deliver counter clockwise rotary event to object: 0x460706e8, elm_box, time_stamp : 10234662
06-25 22:21:00.440+0200 I/wnotib  (  831): w-notification-board-broker-main.c: _wnotib_rotary_cb(559) > Pass rotary event to home.
06-25 22:21:00.445+0200 W/W_HOME  (  831): home_navigation.c: _rotary_cb(1168) > Detent detected, obj[0x46056818], direction[1]
06-25 22:21:00.445+0200 E/W_HOME  (  831): home_navigation.c: _vi_init(954) > (scroller_info->vi_info.on == 1) -> _vi_init() return
06-25 22:21:00.445+0200 W/W_HOME  (  831): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-25 22:21:00.445+0200 W/W_HOME  (  831): home_navigation.c: _nav_finish_timer_add(850) > add timer:1
06-25 22:21:00.445+0200 W/W_HOME  (  831): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
06-25 22:21:00.450+0200 W/W_HOME  (  831): home_navigation.c: _is_rightedge(187) > (1080 360) not right edge: -1080 0 0x496470f8 -> 360 0 0x47209f88
06-25 22:21:00.450+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(633) > [0x46056818 : elm_scroller] rotary callabck is called.
06-25 22:21:00.450+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(663) > [0x46056818 : elm_scroller] block(2)
06-25 22:21:00.450+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(664) > [0x46056818 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
06-25 22:21:00.450+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(665) > [0x46056818 : elm_scroller] content size (w, h)(6480, 360)
06-25 22:21:00.450+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(666) > [0x46056818 : elm_scroller] viewport size (w, h)(360, 360)
06-25 22:21:00.450+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(730) > [0x46056818 : elm_scroller] CurrentPage(3) DetentValue(-1)
06-25 22:21:00.450+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(731) > [0x46056818 : elm_scroller] DetentCount(0)
06-25 22:21:00.450+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(407) > [0x46056818 : elm_scroller] mx(6120), my(0), minx(0), miny(0), px(1080), py(0)
06-25 22:21:00.450+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(407) > [0x46056818 : elm_scroller] mx(6120), my(0), minx(0), miny(0), px(1080), py(0)
06-25 22:21:00.450+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(407) > [0x46056818 : elm_scroller] mx(6120), my(0), minx(0), miny(0), px(1080), py(0)
06-25 22:21:00.450+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(763) > [0x46056818 : elm_scroller] bring in 2 page
06-25 22:21:00.450+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:5560 _elm_scroll_page_bring_in() [0x46056818 : elm_scroller] pagenumber_h(2), pagenumber_v(0)
06-25 22:21:00.450+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x46056818 : elm_scroller] mx(6120), my(0), minx(0), miny(0), px(1080), py(0)
06-25 22:21:00.450+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x46056818 : elm_scroller] cw(6480), ch(360), pw(360), ph(360)
06-25 22:21:00.450+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:1965 _elm_scroll_content_region_show_internal() [0x46056818 : elm_scroller] x(720), y(0), nx(720), px(1080), ny(0) py(0)
06-25 22:21:00.450+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:1991 _elm_scroll_content_region_show_internal() [0x46056818 : elm_scroller] x(720), y(0)
06-25 22:21:00.450+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:5578 _elm_scroll_page_bring_in() [0x46056818 : elm_scroller] _elm_scroll_content_region_show_internal() return TRUE!! x(720), y(0)
06-25 22:21:00.450+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2676 _elm_scroll_scroll_to_x() [0x46056818 : elm_scroller] t_in(0,270000), pos_x(720)
06-25 22:21:00.450+0200 W/W_HOME  (  831): home_navigation.c: _anim_start_cb(1290) > anim start
06-25 22:21:00.450+0200 W/W_HOME  (  831): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-25 22:21:00.450+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2629 _elm_scroll_scroll_to_y() [0x46056818 : elm_scroller] t_in(0,270000), pos_y(0)
06-25 22:21:00.450+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,153600)
06-25 22:21:00.455+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1024), py(0)
06-25 22:21:00.455+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,153600)
06-25 22:21:00.455+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1024), py(0)
06-25 22:21:00.460+0200 I/efl-extension( 3677): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
06-25 22:21:00.460+0200 I/efl-extension( 3677): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
06-25 22:21:00.460+0200 I/efl-extension( 3677): efl_extension_rotary.c: _init_Xi2_system(314) > In
06-25 22:21:00.460+0200 I/efl-extension( 3677): efl_extension_rotary.c: _init_Xi2_system(375) > Done
06-25 22:21:00.460+0200 I/efl-extension( 3677): efl_extension_rotary_selector.c: _event_area_callback_add(500) > called!!
06-25 22:21:00.460+0200 I/efl-extension( 3677): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x437f1c40, elm_layout, _activated_obj : 0x0, activated : 1
06-25 22:21:00.460+0200 I/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 22:21:00.475+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,219035)
06-25 22:21:00.480+0200 E/WMS     (  516): wms_event_handler.c: wms_event_handler_routine(24432) > 
06-25 22:21:00.480+0200 E/WMS     (  516): ==========
06-25 22:21:00.480+0200 E/WMS     (  516): ##WMS RECEIVED : mgr_apps_order_req
06-25 22:21:00.480+0200 E/WMS     (  516): ==========
06-25 22:21:00.480+0200 E/WMS     (  516): wms_event_handler.c: wms_event_handler_routine(24448) > [mgr_apps_order_req] handler success.
06-25 22:21:00.480+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1001), py(0)
06-25 22:21:00.480+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,219035)
06-25 22:21:00.480+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1001), py(0)
06-25 22:21:00.505+0200 W/W_HOME  (  831): wms.c: wms_change_apps_order(59) > Backup
06-25 22:21:00.510+0200 I/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 22:21:00.510+0200 I/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 22:21:00.510+0200 E/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 22:21:00.510+0200 I/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 22:21:00.515+0200 I/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 22:21:00.515+0200 I/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 22:21:00.515+0200 E/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 22:21:00.515+0200 I/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 22:21:00.520+0200 I/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 22:21:00.520+0200 I/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 22:21:00.520+0200 E/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 22:21:00.520+0200 I/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 22:21:00.530+0200 I/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 22:21:00.530+0200 I/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 22:21:00.530+0200 E/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 22:21:00.530+0200 I/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 22:21:00.535+0200 I/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 22:21:00.535+0200 I/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 22:21:00.535+0200 E/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 22:21:00.535+0200 I/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 22:21:00.540+0200 I/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 22:21:00.540+0200 I/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 22:21:00.540+0200 E/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 22:21:00.540+0200 I/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 22:21:00.545+0200 I/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 22:21:00.545+0200 I/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 22:21:00.545+0200 E/efl-extension( 3677): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 22:21:00.545+0200 E/EFL     ( 3677): elementary<3677> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
06-25 22:21:00.555+0200 E/EFL     ( 3677): elementary<3677> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x46645250) will be pushed
06-25 22:21:00.565+0200 I/efl-extension( 3677): efl_extension_rotary_selector.c: _rotary_selector_show_cb(805) > called!!
06-25 22:21:00.570+0200 I/efl-extension( 3677): efl_extension_rotary_selector.c: _rotary_selector_move_cb(776) > called!!
06-25 22:21:00.580+0200 I/APP_CORE( 3677): appcore-efl.c: __do_app(453) > [APP 3677] Event: RESET State: CREATED
06-25 22:21:00.580+0200 I/CAPI_APPFW_APPLICATION( 3677): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
06-25 22:21:00.605+0200 I/APP_CORE( 3677): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
06-25 22:21:00.605+0200 I/APP_CORE( 3677): appcore-efl.c: __do_app(524) > [APP 3677] Initial Launching, call the resume_cb
06-25 22:21:00.605+0200 I/CAPI_APPFW_APPLICATION( 3677): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
06-25 22:21:00.640+0200 W/W_HOME  (  831): wms.c: wms_change_apps_order(72) > done
06-25 22:21:00.645+0200 W/W_HOME  (  831): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
06-25 22:21:00.645+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 3, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 22:21:00.645+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 3, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 22:21:00.645+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 3, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 22:21:00.645+0200 W/W_HOME  (  831): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
06-25 22:21:00.645+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,935632)
06-25 22:21:00.645+0200 I/wnotib  (  831): w-notification-board-basic-panel.c: _wnb_basic_panel_activate(3337) > page_index: 1.
06-25 22:21:00.645+0200 W/W_HOME  (  831): noti_broker.c: _handler_indicator_select(579) > 1
06-25 22:21:00.645+0200 W/W_HOME  (  831): noti_broker.c: _handler_indicator_select(589) > select index:2
06-25 22:21:00.645+0200 W/W_HOME  (  831): noti_broker.c: _handler_indicator_show(539) > 
06-25 22:21:00.645+0200 W/W_HOME  (  831): index.c: index_show(299) > is_paused:0 show VI:1 visibility:1 vi:(nil)
06-25 22:21:00.650+0200 E/WMS     (  516): wms_msg_broker.c: wms_msg_broker_send(1825) > 
06-25 22:21:00.650+0200 E/WMS     (  516): ==========
06-25 22:21:00.650+0200 E/WMS     (  516): ##WMS SEND : mgr_apps_order_res
06-25 22:21:00.650+0200 E/WMS     (  516): ==========
06-25 22:21:00.650+0200 E/WMS     (  516): wms_msg_broker.c: wms_msg_broker_send(1841) > Data size: 4844 MAX Buffer Size: 61440
06-25 22:21:00.655+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(743), py(0)
06-25 22:21:00.655+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,935632)
06-25 22:21:00.655+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(743), py(0)
06-25 22:21:00.675+0200 E/WMS     (  516): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
06-25 22:21:00.680+0200 I/MALI    (  831): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43ecf0e8] swap changed from sync to async
06-25 22:21:00.680+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,988322)
06-25 22:21:00.685+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(724), py(0)
06-25 22:21:00.685+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,988322)
06-25 22:21:00.685+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(724), py(0)
06-25 22:21:00.710+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,999985)
06-25 22:21:00.715+0200 W/wnotib  (  831): w-notification-board-broker-main.c: wnotib_main_dismiss_confirmation_popup(1427) > 
06-25 22:21:00.715+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(720), py(0)
06-25 22:21:00.715+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,999985)
06-25 22:21:00.715+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(720), py(0)
06-25 22:21:00.735+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,992758)
06-25 22:21:00.735+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_CANCEL : px(720), py(0)
06-25 22:21:00.735+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,992758)
06-25 22:21:00.735+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] animation stop!!
06-25 22:21:00.735+0200 W/wnotib  (  831): w-notification-board-panel-manager.c: _wnb_pm_anim_stop_cb(96) > notiboard scroller anim stop [720][0][360][360]
06-25 22:21:00.740+0200 W/wnotib  (  831): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(969) > No postponed update with is_for_VI: 1.
06-25 22:21:00.740+0200 W/W_HOME  (  831): home_navigation.c: _anim_stop_cb(1316) > anim stop
06-25 22:21:00.740+0200 W/W_HOME  (  831): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-25 22:21:00.740+0200 W/W_HOME  (  831): home_navigation.c: _nav_finish_timer_add(850) > add timer:1
06-25 22:21:00.740+0200 W/W_HOME  (  831): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
06-25 22:21:00.740+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(489) > [0x46056818 : elm_scroller] detent_count(-1)
06-25 22:21:00.740+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(490) > [0x46056818 : elm_scroller] pagenumber_v(0), pagenumber_h(2)
06-25 22:21:00.740+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(512) > [0x46056818 : elm_scroller] CurrentPage(2)
06-25 22:21:00.740+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_CANCEL : px(720), py(0)
06-25 22:21:00.755+0200 W/W_INDICATOR(  743): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
06-25 22:21:00.755+0200 W/W_INDICATOR(  743): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[unknown],charge : 0, connected : 0
06-25 22:21:00.755+0200 W/W_INDICATOR(  743): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
06-25 22:21:00.755+0200 W/W_INDICATOR(  743): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-25 22:21:00.790+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1326): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
06-25 22:21:00.790+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1326): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
06-25 22:21:00.790+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1326): preference.c: preference_get_double(1214) > preference_get_double(1326) : pedometer_inactive_period error
06-25 22:21:00.790+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1326): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
06-25 22:21:00.790+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1326): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-25 22:21:00.790+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1326): preference.c: preference_get_double(1214) > preference_get_double(1326) : inactive_10min_precaution_millisec error
06-25 22:21:00.790+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1326): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
06-25 22:21:00.790+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1326): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-25 22:21:00.790+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1326): preference.c: preference_get_double(1214) > preference_get_double(1326) : inactive_before_10min_precaution_millisec error
06-25 22:21:00.845+0200 E/W_HOME  (  831): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
06-25 22:21:00.880+0200 W/W_HOME  (  831): event_manager.c: _home_scroll_cb(585) > scroll,will,done
06-25 22:21:00.880+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 22:21:00.880+0200 W/W_HOME  (  831): event_manager.c: _home_scroll_cb(585) > scroll,done
06-25 22:21:00.880+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 22:21:00.925+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-25 22:21:00.925+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-25 22:21:00.925+0200 I/MESSAGE_PORT(  479): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-25 22:21:00.925+0200 I/MESSAGE_PORT(  479): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-25 22:21:00.925+0200 I/MESSAGE_PORT(  479): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-25 22:21:00.925+0200 I/MESSAGE_PORT(  479): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-25 22:21:00.925+0200 I/MESSAGE_PORT(  479): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-25 22:21:00.925+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-25 22:21:00.930+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-25 22:21:00.930+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-25 22:21:00.930+0200 I/MESSAGE_PORT(  479): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-25 22:21:00.930+0200 I/MESSAGE_PORT(  479): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-25 22:21:00.930+0200 I/MESSAGE_PORT(  479): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-25 22:21:00.930+0200 I/MESSAGE_PORT(  479): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-25 22:21:00.930+0200 I/MESSAGE_PORT(  479): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-25 22:21:00.930+0200 I/MESSAGE_PORT(  479): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-25 22:21:00.930+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-25 22:21:00.930+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-25 22:21:00.940+0200 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 14
06-25 22:21:00.945+0200 W/AUL_AMD (  507): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 3677
06-25 22:21:00.950+0200 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 12
06-25 22:21:00.970+0200 E/CAPI_APPFW_APP_CONTROL( 1411): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-25 22:21:00.970+0200 W/MUSIC_CONTROL_SERVICE( 1411): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1411]   [com.samsung.w-home]register msg port [true][0m
06-25 22:21:00.970+0200 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 14
06-25 22:21:00.975+0200 W/AUL_AMD (  507): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 831
06-25 22:21:00.985+0200 W/SHealthCommon( 1326): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 0[0;m
06-25 22:21:01.000+0200 I/HealthDataService( 1036): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
06-25 22:21:01.005+0200 W/MUSIC_CONTROL_SERVICE( 1411): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1411]   [MUSIC_PLAYER_EVENT][0m
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-25 22:21:01.010+0200 W/MUSIC_CONTROL_SERVICE( 1411): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1411]   [MUSIC_PLAYER_EVENT][0m
06-25 22:21:01.010+0200 W/W_HOME  (  831): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:playing 
06-25 22:21:01.010+0200 E/W_HOME  (  831): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-25 22:21:01.010+0200 W/W_HOME  (  831): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:playing 
06-25 22:21:01.010+0200 E/W_HOME  (  831): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-25 22:21:01.010+0200 I/MESSAGE_PORT(  479): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-25 22:21:01.035+0200 I/healthData( 1326): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
06-25 22:21:01.040+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1326): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
06-25 22:21:01.040+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1326): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
06-25 22:21:01.040+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1326): preference.c: preference_get_double(1214) > preference_get_double(1326) : pedometer_inactive_period error
06-25 22:21:01.040+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1326): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
06-25 22:21:01.040+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1326): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-25 22:21:01.040+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1326): preference.c: preference_get_double(1214) > preference_get_double(1326) : inactive_10min_precaution_millisec error
06-25 22:21:01.040+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1326): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
06-25 22:21:01.040+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1326): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-25 22:21:01.040+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1326): preference.c: preference_get_double(1214) > preference_get_double(1326) : inactive_before_10min_precaution_millisec error
06-25 22:21:01.160+0200 W/CRASH_MANAGER( 3758): worker.c: worker_job(1205) > 110367773636f149842206
