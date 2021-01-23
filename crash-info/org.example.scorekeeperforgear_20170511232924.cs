S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.2
Build-Number: R732XXU2EQC1
Build-Date: 2017.03.13 20:32:41

Crash Information
Process Name: scorekeeperforgear
PID: 13723
Date: 2017-05-11 23:29:24+0200
Executable File Path: /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 13723, uid 5000)

Register Information
r0   = 0x73656465, r1   = 0x00000004
r2   = 0x414c1dd1, r3   = 0x44484368
r4   = 0x73656465, r5   = 0x00000000
r6   = 0x414c1dd1, r7   = 0x414c1dd1
r8   = 0x00000001, r9   = 0x44484368
r10  = 0x44484360, fp   = 0x44484340
ip   = 0x414d33e4, sp   = 0xbedea1c8
lr   = 0x414c1a6d, pc   = 0x418de442
cpsr = 0x20000030

Memory Information
MemTotal:   491132 KB
MemFree:     23772 KB
Buffers:      4132 KB
Cached:      74824 KB
VmPeak:      96940 KB
VmSize:      94716 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       30996 KB
VmRSS:       29784 KB
VmData:      32340 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25420 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 13723 TID = 13723
13723 13795 

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
414be000 414c3000 r-xp /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
414d4000 414d8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
414e1000 414e3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
414ec000 414f2000 r-xp /usr/lib/libappsvc.so.0.1.0
414fa000 4151e000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41527000 415f6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4160c000 41616000 r-xp /lib/libnss_files-2.13.so
418b2000 418bd000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
418c8000 418cd000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
418d5000 418e1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
418ea000 4190b000 r-xp /usr/lib/libefl-extension.so.0.1.0
41913000 41918000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41920000 4194a000 r-xp /usr/lib/libsensor.so.1.9.5
41953000 4195a000 r-xp /usr/lib/libctx-shared.so.0.8.3
41962000 41967000 r-xp /usr/lib/libctx-client.so.0.8.3
4196f000 41981000 r-xp /usr/lib/libefl-assist.so.0.1.0
41989000 41a41000 r-xp /usr/lib/libcairo.so.2.11200.14
41a4c000 41a56000 r-xp /usr/lib/libsensord-shared.so
41a5e000 41a6d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
41a76000 41a8c000 r-xp /usr/lib/libtts.so
41a95000 41ab8000 r-xp /usr/lib/libui-extension.so.0.1.0
41ac1000 41acc000 r-xp /usr/lib/libtbm.so.1.0.0
41ad4000 41ae2000 r-xp /usr/lib/libGLESv2.so.2.0
41aeb000 41aec000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41af5000 41afb000 r-xp /usr/lib/libxcb-render.so.0.0.0
41b03000 41b06000 r-xp /usr/lib/libEGL.so.1.4
41b0e000 41b11000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41b19000 41b1a000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41b23000 41cab000 r-xp /usr/lib/libicui18n.so.57.1
41cbb000 41dc1000 r-xp /usr/lib/libicuuc.so.57.1
41dd7000 41ddf000 r-xp /usr/lib/libdrm.so.2.4.0
41de7000 41de9000 r-xp /usr/lib/libdri2.so.0.0.0
41df1000 41df7000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41dff000 41e04000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41e0c000 41e25000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
436c6000 436e7000 r-xp /usr/lib/libexif.so.12.3.3
436fa000 436fc000 r-xp /usr/lib/libttrace.so.1.1
43704000 43709000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43711000 43717000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43720000 43728000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43730000 43752000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4375b000 43762000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4376b000 4376d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43775000 4377c000 r-xp /usr/lib/libminizip.so.1.0.0
43784000 43791000 r-xp /usr/lib/libail.so.0.1.0
4379a000 437a0000 r-xp /usr/lib/libproc-stat.so.0.2.96
437a8000 437a9000 r-xp /usr/lib/libresponse.so.0.2.96
437b1000 437b6000 r-xp /usr/lib/libsystem.so.0.0.0
437c0000 4388a000 r-xp /usr/lib/libCOREGL.so.4.0
43bbb000 43bc6000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43bcf000 43bd4000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43bdc000 43bf3000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43c00000 43c02000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43c0b000 4440a000 rw-p [stack:13795]
4440a000 4440b000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
4506f000 45070000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
4508e000 45096000 r-xp /usr/lib/libfeedback.so.0.1.4
45098000 45099000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
450a1000 450a3000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
450ab000 450b6000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
450be000 450c5000 r-xp /usr/lib/libmmfcommon.so.0.0.0
450cd000 450e5000 r-xp /usr/lib/libmmfsound.so.0.1.0
450f6000 450fa000 r-xp /usr/lib/libmmfsession.so.0.0.0
45103000 4510e000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
4511b000 4511f000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45127000 4513d000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45145000 451a6000 r-xp /usr/lib/libasound.so.2.0.0
451b0000 451b3000 r-xp /usr/lib/libpulse-simple.so.0.0.4
451bb000 451f3000 r-xp /usr/lib/libpulse.so.0.16.2
451f4000 451f7000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
451ff000 45247000 r-xp /usr/lib/libmdm.so.1.2.62
45248000 4524b000 r-xp /usr/lib/libtinycompress.so.0.0.0
45253000 45258000 r-xp /usr/lib/libjson.so.0.0.1
45260000 452a9000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
452e1000 452f0000 r-xp /usr/lib/libmdm-common.so.1.1.22
45752000 45799000 r-xp /usr/lib/libsndfile.so.1.0.26
457a5000 457c7000 r-xp /usr/lib/libvorbis.so.0.4.3
457cf000 457d3000 r-xp /usr/lib/libogg.so.0.7.1
bedca000 bedeb000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13723)
Call Stack Count: 19
 0: sensor_listener_set_event_cb + 0x15 (0x418de442) [/usr/lib/libcapi-system-sensor.so.0] + 0x9442
 1: SensorProcess::SensorProcess(int) + 0xd8 (0x414c1a6d) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x3a6d
 2: _item_clicked_cb(void*, _Evas_Object*, void*) + 0x56 (0x414c0527) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x2527
 3: evas_object_smart_callback_call + 0x88 (0x402345cd) [/usr/lib/libevas.so.1] + 0x355cd
 4: (0x40365f0d) [/usr/lib/libedje.so.1] + 0x45f0d
 5: (0x40369efd) [/usr/lib/libedje.so.1] + 0x49efd
 6: (0x40366869) [/usr/lib/libedje.so.1] + 0x46869
 7: (0x40366c1b) [/usr/lib/libedje.so.1] + 0x46c1b
 8: (0x40366d55) [/usr/lib/libedje.so.1] + 0x46d55
 9: (0x402fd3f5) [/usr/lib/libecore.so.1] + 0xb3f5
10: (0x402fae53) [/usr/lib/libecore.so.1] + 0x8e53
11: (0x402fe46b) [/usr/lib/libecore.so.1] + 0xc46b
12: ecore_main_loop_begin + 0x30 (0x402fe879) [/usr/lib/libecore.so.1] + 0xc879
13: appcore_efl_main + 0x332 (0x40044b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
14: ui_app_main + 0xb0 (0x41492421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
15: main + 0xb6 (0x414c021b) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x221b
16: (0x40001a53) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x1a53
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
3712
05-11 23:29:20.580+0200 E/WMS     (  515): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-dialer2], Appname[Clavier]
05-11 23:29:20.625+0200 E/WMS     (  515): wms_package_manager.c: get_watch_app_info(705) > app[Galerie] metadata: notification-disable-on-gearmanager
05-11 23:29:20.625+0200 E/WMS     (  515): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-gallery], Appname[Galerie]
05-11 23:29:20.675+0200 E/WMS     (  515): wms_package_manager.c: get_watch_app_info(705) > app[Téléphone] metadata: notification-disable-on-gearmanager
05-11 23:29:20.675+0200 E/WMS     (  515): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-logs2], Appname[Téléphone]
05-11 23:29:20.685+0200 W/W_HOME  (  832): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
05-11 23:29:20.720+0200 E/WMS     (  515): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-magazine-wc1], Appname[News Briefing]
05-11 23:29:20.735+0200 W/AUL     (13785): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.scorekeeperforgear)
05-11 23:29:20.735+0200 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
05-11 23:29:20.745+0200 I/AUL_AMD (  507): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
05-11 23:29:20.755+0200 I/AUL_AMD (  507): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
05-11 23:29:20.755+0200 E/AUL_AMD (  507): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
05-11 23:29:20.755+0200 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 13785
05-11 23:29:20.770+0200 E/RESOURCED(  624): block.c: block_prelaunch_state(138) > insert data org.example.scorekeeperforgear, table num : 19
05-11 23:29:20.775+0200 W/AUL_AMD (  507): amd_launch.c: _start_app(2218) > pad pid(-5)
05-11 23:29:20.775+0200 W/AUL_PAD ( 1315): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
05-11 23:29:20.775+0200 W/AUL_PAD ( 1315): launchpad.c: __send_result_to_caller(272) > Check app launching
05-11 23:29:20.780+0200 W/AUL_PAD (13723): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
05-11 23:29:20.780+0200 W/AUL_PAD (13723): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
05-11 23:29:20.780+0200 W/AUL_PAD (13723): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
05-11 23:29:20.780+0200 W/AUL_PAD (13723): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.scorekeeperforgear)
05-11 23:29:20.810+0200 E/WMS     (  515): wms_package_manager.c: get_watch_app_info(705) > app[Lecteur musique] metadata: notification-disable-on-gearmanager
05-11 23:29:20.810+0200 E/WMS     (  515): wms_package_manager.c: get_watch_app_info(754) > Setting File Exist!: com.samsung.w-music-player_settings.xml
05-11 23:29:20.810+0200 E/WMS     (  515): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-music-player], Appname[Lecteur musique]
05-11 23:29:20.855+0200 I/efl-extension(13723): efl_extension.c: eext_mod_init(40) > Init
05-11 23:29:20.860+0200 I/UXT     (13723): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
05-11 23:29:20.870+0200 W/AUL_PAD (13723): launchpad_loader.c: main(690) > [candidate] dlsym
05-11 23:29:20.870+0200 W/AUL_PAD (13723): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.scorekeeperforgear)
05-11 23:29:20.875+0200 I/CAPI_APPFW_APPLICATION(13723): app_main.c: ui_app_main(704) > app_efl_main
05-11 23:29:20.880+0200 I/CAPI_APPFW_APPLICATION(13723): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-11 23:29:20.885+0200 E/WMS     (  515): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-taskmanager], Appname[Applis récentes]
05-11 23:29:20.955+0200 E/WMS     (  515): wms_package_manager.c: get_watch_app_info(754) > Setting File Exist!: com.samsung.weather_settings.xml
05-11 23:29:20.955+0200 E/WMS     (  515): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.weather], Appname[Météo]
05-11 23:29:20.980+0200 W/AUL     (  507): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.scorekeeperforgear) pid(13723) type(uiapp) bg(0)
05-11 23:29:20.980+0200 W/AUL_AMD (  507): amd_status.c: __socket_monitor_cb(1277) > (13723) was created
05-11 23:29:20.980+0200 W/AUL     (13785): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13723)
05-11 23:29:20.985+0200 W/STARTER (  742): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [13723]
05-11 23:29:21.000+0200 I/CAPI_WATCH_APPLICATION( 3611): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-11 23:29:21.025+0200 E/WMS     (  515): wms_package_manager.c: get_watch_app_info(705) > app[E-mail] metadata: notification-disable-on-gearmanager
05-11 23:29:21.025+0200 E/WMS     (  515): wms_package_manager.c: get_watch_app_info(754) > Setting File Exist!: com.samsung.wemail_settings.xml
05-11 23:29:21.025+0200 E/WMS     (  515): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.wemail], Appname[E-mail]
05-11 23:29:21.050+0200 E/WMS     (  515): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.windicator], Appname[Commandes]
05-11 23:29:21.080+0200 E/WMS     (  515): wms_package_manager.c: get_watch_app_info(705) > app[Notifications] metadata: notification-disable-on-gearmanager
05-11 23:29:21.080+0200 E/WMS     (  515): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.wnotification2], Appname[Notifications]
05-11 23:29:21.105+0200 E/WMS     (  515): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.worldclock], Appname[Horloge mondiale]
05-11 23:29:21.140+0200 E/WMS     (  515): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.spotify.w-spotify], Appname[Spotify]
05-11 23:29:21.155+0200 I/efl-extension(13723): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1242) > Put the surface[0x417f5cd0]'s widget[0x417fb730] to elm_conformant widget[0x417be880]
05-11 23:29:21.160+0200 I/efl-extension(13723): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
05-11 23:29:21.165+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_add(1990) > called!!
05-11 23:29:21.180+0200 E/WMS     (  515): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[du78TVHggk], Appname[GoogleMap]
05-11 23:29:21.215+0200 E/WMS     (  515): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[m9Sb04ZlB7], Appname[Yelp]
05-11 23:29:21.220+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: _eext_rotary_selector_data_init(586) > rsd is initialized!!
05-11 23:29:21.245+0200 E/WMS     (  515): wms_package_manager.c: get_watch_app_info(803) > SAP Setting File Path: /opt/usr/apps/oQbQH11Tzv/res/wgt/res/xml/accessoryservices.xml
05-11 23:29:21.260+0200 E/WMS     (  515): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[oQbQH11Tzv], Appname[Running]
05-11 23:29:21.305+0200 E/WMS     (  515): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[org.example.basicuiwithedc2], Appname[basicuiwithedc2]
05-11 23:29:21.315+0200 I/efl-extension(13723): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-11 23:29:21.315+0200 I/efl-extension(13723): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-11 23:29:21.315+0200 I/efl-extension(13723): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-11 23:29:21.330+0200 I/efl-extension(13723): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-11 23:29:21.330+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: _event_area_callback_add(500) > called!!
05-11 23:29:21.330+0200 I/efl-extension(13723): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x417fca48, elm_layout, _activated_obj : 0x0, activated : 1
05-11 23:29:21.330+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
05-11 23:29:21.350+0200 E/WMS     (  515): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[org.example.scorekeeperforgear], Appname[scorekeeperforgear]
05-11 23:29:21.370+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
05-11 23:29:21.370+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
05-11 23:29:21.370+0200 E/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
05-11 23:29:21.370+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
05-11 23:29:21.375+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
05-11 23:29:21.375+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
05-11 23:29:21.375+0200 E/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
05-11 23:29:21.375+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
05-11 23:29:21.390+0200 E/WMS     (  515): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[org.example.stopwatch], Appname[stopwatch]
05-11 23:29:21.415+0200 E/WMS     (  515): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[org.example.uicomponents], Appname[uicomponents]
05-11 23:29:21.445+0200 E/WMS     (  515): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[org.tizen.tizenseckeystring], Appname[Tizen Keystring]
05-11 23:29:21.520+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
05-11 23:29:21.520+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
05-11 23:29:21.520+0200 E/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
05-11 23:29:21.520+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
05-11 23:29:21.540+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
05-11 23:29:21.540+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
05-11 23:29:21.540+0200 E/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
05-11 23:29:21.540+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
05-11 23:29:21.550+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
05-11 23:29:21.550+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
05-11 23:29:21.555+0200 E/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
05-11 23:29:21.555+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
05-11 23:29:21.555+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
05-11 23:29:21.560+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
05-11 23:29:21.560+0200 E/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
05-11 23:29:21.560+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
05-11 23:29:21.560+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
05-11 23:29:21.565+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
05-11 23:29:21.565+0200 E/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
05-11 23:29:21.565+0200 E/EFL     (13723): elementary<13723> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
05-11 23:29:21.575+0200 E/EFL     (13723): elementary<13723> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x44470908) will be pushed
05-11 23:29:21.600+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: _rotary_selector_show_cb(805) > called!!
05-11 23:29:21.610+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: _rotary_selector_move_cb(776) > called!!
05-11 23:29:21.620+0200 I/APP_CORE(13723): appcore-efl.c: __do_app(453) > [APP 13723] Event: RESET State: CREATED
05-11 23:29:21.620+0200 I/CAPI_APPFW_APPLICATION(13723): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-11 23:29:21.665+0200 W/W_HOME  (  832): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
05-11 23:29:21.665+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:29:21.665+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:29:21.665+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:29:21.665+0200 W/W_HOME  (  832): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
05-11 23:29:21.675+0200 I/APP_CORE(13723): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
05-11 23:29:21.675+0200 I/APP_CORE(13723): appcore-efl.c: __do_app(524) > [APP 13723] Initial Launching, call the resume_cb
05-11 23:29:21.675+0200 I/CAPI_APPFW_APPLICATION(13723): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-11 23:29:21.700+0200 E/CAPI_TELEPHONY(  515): telephony_common.c: telephony_init(358) > telephony feature is disabled
05-11 23:29:21.705+0200 W/APP_CORE(13723): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6400002
05-11 23:29:21.715+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: _rotary_selector_move_cb(776) > called!!
05-11 23:29:21.715+0200 I/efl-extension(13723): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(649) > surface 0x417f5cd0 = w: 1 h: 1  obj 0x417fb730 w: 360 h: 360
05-11 23:29:21.715+0200 I/efl-extension(13723): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(673) > Surface will be initialized! surface->w= 360 surface->h = 360
05-11 23:29:21.715+0200 I/MALI    (  832): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43ecf100] swap changed from sync to async
05-11 23:29:21.720+0200 W/W_INDICATOR(  743): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
05-11 23:29:21.720+0200 W/W_INDICATOR(  743): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
05-11 23:29:21.735+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: _item_update_animator_cb(1414) > called
05-11 23:29:21.735+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: _item_update_animator_cb(1423) > item_list(0x1145269432), count(7)
05-11 23:29:21.930+0200 W/W_HOME  (  832): event_manager.c: _window_visibility_cb(466) > Window [0x2E00003] is now visible(1)
05-11 23:29:21.930+0200 W/W_HOME  (  832): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
05-11 23:29:21.930+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:29:21.930+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:29:21.935+0200 E/W_HOME  (  832): win.c: win_rotation_disable_set(186) > failed to get key VCONFKEY_DISABLE_ROTATION
05-11 23:29:21.935+0200 W/W_HOME  (  832): main.c: _window_visibility_cb(963) > Window [0x2E00003] is now visible(1)
05-11 23:29:21.935+0200 I/APP_CORE(  832): appcore-efl.c: __do_app(453) > [APP 832] Event: PAUSE State: RUNNING
05-11 23:29:21.935+0200 I/CAPI_APPFW_APPLICATION(  832): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-11 23:29:21.935+0200 W/W_HOME  (  832): main.c: _appcore_pause_cb(487) > appcore pause
05-11 23:29:21.935+0200 W/W_HOME  (  832): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
05-11 23:29:21.935+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:29:21.935+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:29:21.935+0200 W/W_HOME  (  832): main.c: home_pause(546) > clock/widget paused
05-11 23:29:21.935+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:29:21.935+0200 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-11 23:29:21.935+0200 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-11 23:29:21.935+0200 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-11 23:29:21.935+0200 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-11 23:29:21.935+0200 I/MESSAGE_PORT(  483): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-11 23:29:21.935+0200 I/MESSAGE_PORT(  483): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-11 23:29:21.935+0200 I/MESSAGE_PORT(  483): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-11 23:29:21.935+0200 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-11 23:29:21.935+0200 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-11 23:29:21.935+0200 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-11 23:29:21.935+0200 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-11 23:29:21.935+0200 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-11 23:29:21.935+0200 I/MESSAGE_PORT(  483): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-11 23:29:21.935+0200 I/MESSAGE_PORT(  483): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-11 23:29:21.935+0200 I/MESSAGE_PORT(  483): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-11 23:29:21.935+0200 I/MESSAGE_PORT(  483): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-11 23:29:21.935+0200 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-11 23:29:21.935+0200 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-11 23:29:21.935+0200 E/CAPI_APPFW_APP_CONTROL(22830): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-11 23:29:21.935+0200 W/MUSIC_CONTROL_SERVICE(22830): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:22830]   [com.samsung.w-home]register msg port [false][0m
05-11 23:29:21.935+0200 I/wnotib  (  832): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
05-11 23:29:21.935+0200 E/wnotib  (  832): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-11 23:29:21.935+0200 W/wnotib  (  832): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [225], notiboard card appending count [440].
05-11 23:29:21.940+0200 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(832) status(bg) type(uiapp)
05-11 23:29:21.940+0200 W/STARTER (  742): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[832] goes to (4)
05-11 23:29:21.940+0200 E/STARTER (  742): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 832)'s state(4)
05-11 23:29:21.945+0200 W/AUL_AMD (  507): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-11 23:29:21.945+0200 W/AUL_AMD (  507): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-11 23:29:21.945+0200 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.scorekeeperforgear) pid(13723) status(fg) type(uiapp)
05-11 23:29:21.945+0200 W/STARTER (  742): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[13723] goes to (3)
05-11 23:29:21.990+0200 E/PKGMGR_SERVER(13711): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
05-11 23:29:21.990+0200 E/PKGMGR_SERVER(13711): pkgmgr-server.c: main(2296) > package manager server terminated.
05-11 23:29:22.000+0200 I/CAPI_WATCH_APPLICATION( 3611): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-11 23:29:22.000+0200 W/WATCH_CORE( 3611): appcore-watch.c: __widget_pause(1113) > widget_pause
05-11 23:29:22.000+0200 W/AUL     ( 3611): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(F1avfmJXBt.CyberWatch) pid(3611) status(bg) type(watchapp)
05-11 23:29:22.090+0200 E/TBM     (  470): tbm_bufmgr.c: _tgl_destroy(141) > [libtbm:470] error(Device or resource busy) _tgl_destroy:141 key:73
05-11 23:29:22.095+0200 I/APP_CORE(13723): appcore-efl.c: __do_app(453) > [APP 13723] Event: RESUME State: RUNNING
05-11 23:29:22.195+0200 W/W_INDICATOR(  743): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
05-11 23:29:22.195+0200 W/W_INDICATOR(  743): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
05-11 23:29:22.240+0200 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 14
05-11 23:29:22.250+0200 W/AUL_AMD (  507): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 13723
05-11 23:29:22.250+0200 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 14
05-11 23:29:22.255+0200 W/AUL_AMD (  507): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 13723
05-11 23:29:22.260+0200 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 12
05-11 23:29:22.265+0200 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 12
05-11 23:29:22.330+0200 E/AUL     (  507): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-11 23:29:22.435+0200 I/APP_CORE(  832): appcore-efl.c: __do_app(453) > [APP 832] Event: MEM_FLUSH State: PAUSED
05-11 23:29:22.720+0200 E/WMS     (  515): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(505) > telephony : 0
05-11 23:29:22.720+0200 E/WMS     (  515): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(506) > wifi : 1
05-11 23:29:22.720+0200 E/WMS     (  515): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(510) > scs : true
05-11 23:29:22.725+0200 E/WMS     (  515): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(526) > svoice not disabled
05-11 23:29:22.725+0200 E/PKGMGR_INFO(  515): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_destroy_pkginfo(1915) > (handle == NULL) pkginfo handle is NULL
05-11 23:29:22.730+0200 E/WMS     (  515): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(545) > camera : 0
05-11 23:29:22.740+0200 E/WMS     (  515): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(560) > wps : 1
05-11 23:29:22.745+0200 E/WMS     (  515): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(566) > speaker : 0
05-11 23:29:22.750+0200 E/WMS     (  515): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(572) > width : 360
05-11 23:29:22.760+0200 E/WMS     (  515): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(578) > height : 360
05-11 23:29:22.765+0200 E/WMS     (  515): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(584) > barometer : 1
05-11 23:29:22.770+0200 E/WMS     (  515): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(590) > magnetometer : 0
05-11 23:29:22.780+0200 E/WMS     (  515): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(596) > photometer : 1
05-11 23:29:22.785+0200 E/WMS     (  515): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(602) > heartrate : 1
05-11 23:29:22.790+0200 E/WMS     (  515): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(608) > ultraviolet : 0
05-11 23:29:22.800+0200 E/WMS     (  515): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(614) > irled : 0
05-11 23:29:22.805+0200 E/WMS     (  515): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(691) > push : 1
05-11 23:29:22.805+0200 E/WMS     (  515): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(702) > auto connection : true
05-11 23:29:22.835+0200 E/PKGMGR_INFO(  515): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_destroy_pkginfo(1915) > (handle == NULL) pkginfo handle is NULL
05-11 23:29:22.845+0200 E/WMS     (  515): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(775) > support hfp : 0
05-11 23:29:22.850+0200 E/WMS     (  515): wms_msg_broker.c: wms_msg_broker_send(1825) > 
05-11 23:29:22.850+0200 E/WMS     (  515): ==========
05-11 23:29:22.850+0200 E/WMS     (  515): ##WMS SEND : mgr_wearable_status_res
05-11 23:29:22.850+0200 E/WMS     (  515): ==========
05-11 23:29:22.850+0200 E/WMS     (  515): wms_msg_broker.c: wms_msg_broker_send(1841) > Data size: 19305 MAX Buffer Size: 61440
05-11 23:29:22.850+0200 E/WMS     (  515): wms_msg_broker.c: wms_msg_broker_send(1825) > 
05-11 23:29:22.850+0200 E/WMS     (  515): ==========
05-11 23:29:22.850+0200 E/WMS     (  515): ##WMS SEND : mgr_host_status_req
05-11 23:29:22.850+0200 E/WMS     (  515): ==========
05-11 23:29:22.850+0200 E/WMS     (  515): wms_msg_broker.c: wms_msg_broker_send(1841) > Data size: 52 MAX Buffer Size: 61440
05-11 23:29:22.850+0200 E/WMS     (  515): wms_event_handler.c: handle_mgr_wearable_status_req(16911) > handle_mgr_wearable_status_req completed
05-11 23:29:22.850+0200 E/WMS     (  515): wms_event_handler.c: wms_event_handler_routine(24448) > [mgr_wearable_status_req] handler success.
05-11 23:29:22.880+0200 E/WMS     (  515): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
05-11 23:29:22.895+0200 E/WMS     (  515): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
05-11 23:29:22.955+0200 W/MM_CAMCORDER(13725): mm_camcorder_internal.c: _mmcamcorder_constructor(203) >  start
05-11 23:29:22.955+0200 W/MM_CAMCORDER(13725): mm_camcorder_internal.c: _mmcamcorder_constructor(213) >  done
05-11 23:29:22.980+0200 I/efl-extension(13725): efl_extension.c: eext_mod_init(40) > Init
05-11 23:29:23.000+0200 E/WMS     (  515): wms_event_handler.c: wms_event_handler_routine(24432) > 
05-11 23:29:23.000+0200 E/WMS     (  515): ==========
05-11 23:29:23.000+0200 E/WMS     (  515): ##WMS RECEIVED : mgr_apps_order_req
05-11 23:29:23.000+0200 E/WMS     (  515): ==========
05-11 23:29:23.005+0200 E/WMS     (  515): wms_event_handler.c: wms_event_handler_routine(24448) > [mgr_apps_order_req] handler success.
05-11 23:29:23.005+0200 W/W_HOME  (  832): wms.c: wms_change_apps_order(59) > Backup
05-11 23:29:23.110+0200 W/W_HOME  (  832): wms.c: wms_change_apps_order(72) > done
05-11 23:29:23.115+0200 E/WMS     (  515): wms_msg_broker.c: wms_msg_broker_send(1825) > 
05-11 23:29:23.115+0200 E/WMS     (  515): ==========
05-11 23:29:23.115+0200 E/WMS     (  515): ##WMS SEND : mgr_apps_order_res
05-11 23:29:23.115+0200 E/WMS     (  515): ==========
05-11 23:29:23.115+0200 E/WMS     (  515): wms_msg_broker.c: wms_msg_broker_send(1841) > Data size: 4401 MAX Buffer Size: 61440
05-11 23:29:23.135+0200 E/WMS     (  515): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
05-11 23:29:23.285+0200 I/AUL_PAD (13788): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-11 23:29:23.375+0200 E/EFL     (13723): ecore_x<13723> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=121146376 button=1
05-11 23:29:23.575+0200 E/WMS     (  515): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
05-11 23:29:23.655+0200 E/EFL     (13723): ecore_x<13723> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=121146607 button=1
05-11 23:29:23.780+0200 I/WSM     ( 1149): WSM_I [Run, line = 118, thread  = 413d5460] Read request from client. 
05-11 23:29:23.780+0200 I/WSM     ( 1149): WSM_I [Run] Request len 406c 
05-11 23:29:23.780+0200 I/WSM     ( 1149): WSM_D [Run] Request data  =  [len=16492] 61636b6180030000c8536e19561f7d40368f87ad49c91d9c02892dd37ef646b120cecc6ec38e721d5d85ec75f4302acff2cf8411e459609b26164f7e18b7bd3cf829abd51de1c09919ee1259166522f90be006edb1a02ffc13d962009de4314ccceb1460f6592bfc3fa4a03eb229a6c7fb071634f0dc25c24548dfd51e6361391db0fb4d14dc2234b56f9dda832e64adf6033d939a2c85cb72a07d2a3cc23658da6f791fa323a90390a0869e415d1599260d05d15b6dcddbb32e34befe8b748af01c280f8de32279aeb33f700513f594c9d413f2b081cee9c2baa63e12e98ffe217cf74ce3aea68bc12ce86b64453cad160c0034250476125802cb08a8cbe06909d8f4de560082f2fc2274402b4595050f983d3821649567ca5ab06abb5927c50a7dc95f149947677d7d99061fdc2bbb961f1ea93636764e2e2bec95472b32f767c473545b26f076f78b5bffcadf608e9cd8d1a99ffc7bb70dd70bfbbe620b246ce34e4d64c05bab0fa978670084bcd065a6e83180b4f87c60e67fafaefab60b728d2d66baff3edb0267bcb0877600afc6fa04c0b8f096e9910cae239ac76d63cd0d59791d2311b006d84cd9618a3dfdbad3e7c754a1db1a6d2fc26a779a6283de0b1e9507e35b7e975cc594854db97d25f90b14a42bab37b47db70b6d65230b876ad1c87ff97e0674029a
05-11 23:29:23.785+0200 I/WSM     ( 1149): WSM_I [Run, line = 150] Send reply to client.
05-11 23:29:23.785+0200 I/WSM     ( 1149): WSM_D [Run] Send reply =  [len=16492] 0100000080030000ad9c2642561f7d40368f87ad49c91d9c02892dd37ef646b120cecc6ec38e721d5d85ec75f4302acff2cf8411e459609b26164f7e18b7bd3cf829abd51de1c09919ee1259166522f90be006edb1a02ffc13d962009de4314ccceb1460f6592bfc3fa4a03eb229a6c7fb071634f0dc25c24548dfd51e6361391db0fb4d14dc2234b56f9dda832e64adf6033d939a2c85cb72a07d2a3cc23658da6f791fa323a90390a0869e415d1599260d05d15b6dcddbb32e34befe8b748af01c280f8de32279aeb33f700513f594c9d413f2b081cee9c2baa63e12e98ffe217cf74ce3aea68bc12ce86b64453cad160c0034250476125802cb08a8cbe06909d8f4de560082f2fc2274402b4595050f983d3821649567ca5ab06abb5927c50a7dc95f149947677d7d99061fdc2bbb961f1ea93636764e2e2bec95472b32f767c473545b26f076f78b5bffcadf608e9cd8d1a99ffc7bb70dd70bfbbe620b246ce34e4d64c05bab0fa978670084bcd065a6e83180b4f87c60e67fafaefab60b728d2d66baff3edb0267bcb0877600afc6fa04c0b8f096e9910cae239ac76d63cd0d59791d2311b006d84cd9618a3dfdbad3e7c754a1db1a6d2fc26a779a6283de0b1e9507e35b7e975cc594854db97d25f90b14a42bab37b47db70b6d65230b876ad1c87ff97e0674029a466
05-11 23:29:23.795+0200 E/WMS     (  515): wms_event_handler.c: wms_event_handler_routine(24432) > 
05-11 23:29:23.795+0200 E/WMS     (  515): ==========
05-11 23:29:23.795+0200 E/WMS     (  515): ##WMS RECEIVED : mgr_host_status_res
05-11 23:29:23.795+0200 E/WMS     (  515): ==========
05-11 23:29:23.795+0200 E/WMS     (  515): wms_event_handler.c: handle_mgr_host_status_res(17032) > type : sync
05-11 23:29:23.795+0200 E/WMS     (  515): wms_event_handler.c: handle_mgr_host_status_res(17035) > preinstalled: true
05-11 23:29:23.800+0200 E/WMS     (  515): wms_msg_broker.c: wms_msg_broker_send(1825) > 
05-11 23:29:23.800+0200 E/WMS     (  515): ==========
05-11 23:29:23.800+0200 E/WMS     (  515): ##WMS SEND : mgr_status_exchange_done
05-11 23:29:23.800+0200 E/WMS     (  515): ==========
05-11 23:29:23.800+0200 E/WMS     (  515): wms_msg_broker.c: wms_msg_broker_send(1841) > Data size: 73 MAX Buffer Size: 61440
05-11 23:29:23.805+0200 E/WMS     (  515): wms_status_manager.c: wms_status_manager_get_device_status(875) > Host device vendor: samsung
05-11 23:29:23.810+0200 E/WMS     (  515): wms_status_manager.c: wms_status_manager_get_device_status(880) > Host device salescode: XEF
05-11 23:29:23.810+0200 E/wnoti-service( 1152): wnoti-sap-client.c: _get_vendor_cb(3568) > vendor : samsung, vendor_type : 0
05-11 23:29:23.815+0200 W/APP_SHORTCUT_WIDGET(22748): main.c: _vendor_changed_cb(446) >  vendor : samsung
05-11 23:29:23.825+0200 E/WMS     (  515): wms_status_manager.c: wms_status_manager_get_device_status(890) > host mcc [208], mnc [15]
05-11 23:29:23.825+0200 E/WMS     (  515): wms_xml_util.c: wms_xml_util_get_nodeset(62) > No result
05-11 23:29:23.845+0200 E/WMS     (  515): wms_status_manager.c: wms_status_manager_sync_host_status(1249) > host platform version: 6.0.1
05-11 23:29:23.855+0200 E/WMS     (  515): wms_status_manager.c: wms_status_manager_sync_host_status(1286) > vendor[samsung:samsungMass] matches. app[com.samsung.wemail]
05-11 23:29:23.860+0200 E/WMS     (  515): wms_status_manager.c: wms_status_manager_sync_host_status(1437) > Host telephony feature is supported - enable call app
05-11 23:29:23.885+0200 E/WMS     (  515): wms_status_manager.c: wms_status_manager_sync_host_status(1489) > vendor[ samsung ], support.email.sync[ true ]
05-11 23:29:23.895+0200 E/PKGMGR  (  515): pkgmgr.c: pkgmgr_client_enable(2552) > enable pkg[com.samsung.call] start
05-11 23:29:24.005+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: _selector_clicked_signal(1784) > called!!
05-11 23:29:24.005+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_selected_item_get(2961) > called!!
05-11 23:29:24.005+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_get(2370) > called!!
05-11 23:29:24.005+0200 I/efl-extension(13723): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_get(2370) > called!!
05-11 23:29:24.345+0200 I/capability-manager(13794): capability_manager_util.c: is_file_exist(120) > File /opt/usr/share/wms/HostStatus.xml Exists
05-11 23:29:24.345+0200 I/capability-manager(13794): capability_manager_xml.c: capability_manager_xml_util_get_device_info(114) > capability_manager_xml_util_get_device_info() called.
05-11 23:29:24.350+0200 W/APPS    (  832): apps_main.c: apps_main_is_hide_message(1387) >  isHide[0]
05-11 23:29:24.355+0200 W/wnotib  (  832): w-notification-board-broker-main.c: _wnotib_wms_host_status_vendor_changed_cb(329) > vendor: samsung.
05-11 23:29:24.355+0200 I/wnotib  (  832): w-notification-board-empty-panel.c: _wnb_empty_panel_message_receive(59) > type: 24
05-11 23:29:24.375+0200 I/wnotib  (  832): w-notification-board-empty-panel.c: _wnb_ep_set_texts(346) > is_connected_vendor_LO: 0, is_standalone_mode: 0
05-11 23:29:24.375+0200 E/TIZEN_N_SYSTEM_SETTINGS(  832): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-11 23:29:24.375+0200 E/TIZEN_N_SYSTEM_SETTINGS(  832): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-11 23:29:24.375+0200 E/TIZEN_N_SYSTEM_SETTINGS(  832): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-11 23:29:24.375+0200 E/TIZEN_N_SYSTEM_SETTINGS(  832): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-11 23:29:24.380+0200 E/PKGMGR_SERVER(13798): pkgmgr-server.c: main(2242) > package manager server start
05-11 23:29:24.455+0200 W/W_HOME  (  832): clock_view_indicator.c: _view_remove_by_type(267) > removed:3
05-11 23:29:24.455+0200 W/W_HOME  (  832): clock_indicator.c: clock_indicator_pop(364) > icon:3(0) is popped from clock indicator
05-11 23:29:24.455+0200 W/W_HOME  (  832): cfwd.c: cfwd_get_icon_status(362) > 
05-11 23:29:24.455+0200 W/W_HOME  (  832): ============================
05-11 23:29:24.455+0200 W/W_HOME  (  832): multi_sim_category:0
05-11 23:29:24.455+0200 W/W_HOME  (  832): multi_sim_model:0
05-11 23:29:24.455+0200 W/W_HOME  (  832): support_callforward_auto:0
05-11 23:29:24.455+0200 W/W_HOME  (  832): conn_status:1
05-11 23:29:24.455+0200 W/W_HOME  (  832): remote_call_forward_auto:0
05-11 23:29:24.455+0200 W/W_HOME  (  832): auto_call_forward_status:0
05-11 23:29:24.455+0200 W/W_HOME  (  832): support_callforward_reverse:0
05-11 23:29:24.455+0200 W/W_HOME  (  832): reverse_call_forward_auto:0
05-11 23:29:24.455+0200 W/W_HOME  (  832): fwd_type:
05-11 23:29:24.455+0200 W/W_HOME  (  832): ============================
05-11 23:29:24.455+0200 W/W_HOME  (  832): 
05-11 23:29:24.455+0200 W/W_HOME  (  832): clock_view_indicator.c: _view_call_fw_icon(136) > call fwd status:0
05-11 23:29:24.540+0200 W/STARTER (  742): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[832] goes to (3)
05-11 23:29:24.540+0200 E/STARTER (  742): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 832)'s state(3)
05-11 23:29:24.540+0200 W/AUL_AMD (  507): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-11 23:29:24.540+0200 W/AUL_AMD (  507): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-11 23:29:24.540+0200 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(832) status(fg) type(uiapp)
05-11 23:29:24.560+0200 E/PKGMGR  (  515): pkgmgr.c: pkgmgr_client_enable(2638) > enable pkg finish, ret=[0]
05-11 23:29:24.560+0200 E/PKGMGR  (  515): pkgmgr.c: pkgmgr_client_disable(2645) > disable pkg[] start
05-11 23:29:24.575+0200 E/PKGMGR_SERVER(13804): pkgmgr-server.c: queue_job(1981) > ENABLE_PKG start, pkgid=[com.samsung.call]
05-11 23:29:24.600+0200 W/AUL_PAD ( 1315): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 13723 pgid = 13723
05-11 23:29:24.600+0200 W/AUL_PAD ( 1315): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
05-11 23:29:24.605+0200 E/EFL     (  470): ecore_x<470> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x6400002 time=121147612
05-11 23:29:24.615+0200 E/PKGMGR_SERVER(13805): pkgmgr-server.c: queue_job(1990) > DISABLE_PKG start, pkgid=[]
05-11 23:29:24.665+0200 W/PROCESSMGR(  470): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
05-11 23:29:24.695+0200 E/PKGMGR  (  515): pkgmgr.c: pkgmgr_client_disable(2731) > disable pkg finish, ret=[0]
05-11 23:29:24.710+0200 W/WATCH_CORE( 3611): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-11 23:29:24.710+0200 I/WATCH_CORE( 3611): appcore-watch.c: __signal_process_manager_handler(1273) > Skip the background tick update
05-11 23:29:24.720+0200 W/W_HOME  (  832): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
05-11 23:29:24.720+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:29:24.720+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:29:24.725+0200 E/CAPI_TELEPHONY(  515): telephony_common.c: telephony_init(358) > telephony feature is disabled
05-11 23:29:24.740+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:29:24.740+0200 W/W_HOME  (  832): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 1
05-11 23:29:24.750+0200 W/W_HOME  (  832): event_manager.c: _window_visibility_cb(466) > Window [0x2E00003] is now visible(0)
05-11 23:29:24.750+0200 W/W_HOME  (  832): event_manager.c: _window_visibility_cb(476) > state: 0 -> 1
05-11 23:29:24.750+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:29:24.750+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:29:24.755+0200 E/W_HOME  (  832): win.c: win_rotation_disable_set(186) > failed to get key VCONFKEY_DISABLE_ROTATION
05-11 23:29:24.755+0200 W/W_HOME  (  832): main.c: _window_visibility_cb(963) > Window [0x2E00003] is now visible(0)
05-11 23:29:24.755+0200 I/APP_CORE(  832): appcore-efl.c: __do_app(453) > [APP 832] Event: RESUME State: PAUSED
05-11 23:29:24.755+0200 I/CAPI_APPFW_APPLICATION(  832): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-11 23:29:24.755+0200 W/W_HOME  (  832): main.c: _appcore_resume_cb(478) > appcore resume
05-11 23:29:24.755+0200 W/W_HOME  (  832): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
05-11 23:29:24.755+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:29:24.755+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:29:24.755+0200 W/W_HOME  (  832): main.c: home_resume(526) > journal_multimedia_screen_loaded_home called
05-11 23:29:24.755+0200 W/W_HOME  (  832): main.c: home_resume(530) > clock/widget resumed
05-11 23:29:24.755+0200 E/W_HOME  (  832): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
05-11 23:29:24.755+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:29:24.755+0200 I/wnotib  (  832): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 0
05-11 23:29:24.755+0200 E/wnotib  (  832): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-11 23:29:24.755+0200 W/wnotib  (  832): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
05-11 23:29:24.770+0200 W/WATCH_CORE( 3611): appcore-watch.c: __widget_resume(1124) > widget_resume
05-11 23:29:24.770+0200 W/AUL     ( 3611): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(F1avfmJXBt.CyberWatch) pid(3611) status(fg) type(watchapp)
05-11 23:29:24.770+0200 I/CAPI_WATCH_APPLICATION( 3611): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-11 23:29:24.775+0200 W/W_INDICATOR(  743): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 1
05-11 23:29:24.775+0200 W/W_INDICATOR(  743): windicator_battery.c: windicator_battery_vconfkey_register(422) > [windicator_battery_vconfkey_register:422] Set battery cb
05-11 23:29:24.775+0200 W/W_INDICATOR(  743): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
05-11 23:29:24.775+0200 W/W_INDICATOR(  743): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(57), length(2)
05-11 23:29:24.775+0200 W/W_INDICATOR(  743): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 57%
05-11 23:29:24.775+0200 W/W_INDICATOR(  743): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 57, isCharging: 0
05-11 23:29:24.775+0200 W/W_INDICATOR(  743): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_60
05-11 23:29:24.775+0200 W/W_INDICATOR(  743): windicator_battery.c: windicator_battery_icon_update(381) > [windicator_battery_icon_update:381] Normal charging status !!
05-11 23:29:24.855+0200 W/AUL_PAD ( 1315): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
05-11 23:29:24.880+0200 I/AUL_AMD (  507): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 13723
05-11 23:29:24.880+0200 W/AUL     (  507): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(13723)
05-11 23:29:25.000+0200 I/CAPI_WATCH_APPLICATION( 3611): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-11 23:29:25.090+0200 W/CRASH_MANAGER(13803): worker.c: worker_job(1205) > 111372373636f149453816
