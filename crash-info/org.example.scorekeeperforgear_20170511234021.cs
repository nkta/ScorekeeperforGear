S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.2
Build-Number: R732XXU2EQC1
Build-Date: 2017.03.13 20:32:41

Crash Information
Process Name: scorekeeperforgear
PID: 14377
Date: 2017-05-11 23:40:21+0200
Executable File Path: /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 14377, uid 5000)

Register Information
r0   = 0x3a726f72, r1   = 0x00000004
r2   = 0x414c1dd1, r3   = 0x45c7aac8
r4   = 0x3a726f72, r5   = 0x00000000
r6   = 0x414c1dd1, r7   = 0x414c1dd1
r8   = 0x00000001, r9   = 0x45c7aac8
r10  = 0x45c7aac0, fp   = 0x45c7aaa0
ip   = 0x414d33e4, sp   = 0xbec011c8
lr   = 0x414c1a6d, pc   = 0x418de442
cpsr = 0x20000030

Memory Information
MemTotal:   491132 KB
MemFree:     16444 KB
Buffers:      4704 KB
Cached:      82440 KB
VmPeak:     104104 KB
VmSize:      98388 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28388 KB
VmRSS:       24684 KB
VmData:      36012 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25420 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 14377 TID = 14377
14377 14434 

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
43c0b000 4440a000 rw-p [stack:14434]
4440a000 4440b000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
459ec000 459ed000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
45a0b000 45a13000 r-xp /usr/lib/libfeedback.so.0.1.4
45a15000 45a16000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
45a1e000 45a20000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
45a28000 45a33000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
45a3b000 45a42000 r-xp /usr/lib/libmmfcommon.so.0.0.0
45a4a000 45a62000 r-xp /usr/lib/libmmfsound.so.0.1.0
45a73000 45a77000 r-xp /usr/lib/libmmfsession.so.0.0.0
45a80000 45a8b000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45a98000 45a9c000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45aa4000 45aa7000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45d32000 45d48000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45d50000 45db1000 r-xp /usr/lib/libasound.so.2.0.0
45dbb000 45df3000 r-xp /usr/lib/libpulse.so.0.16.2
45df4000 45df7000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
45dff000 45e47000 r-xp /usr/lib/libmdm.so.1.2.62
45e48000 45e4b000 r-xp /usr/lib/libtinycompress.so.0.0.0
45e53000 45e58000 r-xp /usr/lib/libjson.so.0.0.1
45e60000 45ea9000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45eb2000 45ef9000 r-xp /usr/lib/libsndfile.so.1.0.26
45f05000 45f14000 r-xp /usr/lib/libmdm-common.so.1.1.22
45f1d000 45f3f000 r-xp /usr/lib/libvorbis.so.0.4.3
45f47000 45f4b000 r-xp /usr/lib/libogg.so.0.7.1
bebe1000 bec02000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14377)
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
 px(3600), py(0)
05-11 23:40:17.610+0200 I/efl-extension(11482): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 23:40:17.610+0200 I/efl-extension( 5745): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 23:40:17.610+0200 I/efl-extension( 3611): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 23:40:17.610+0200 I/efl-extension( 5755): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 23:40:17.610+0200 I/efl-extension(21196): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 23:40:17.610+0200 I/efl-extension( 4321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 23:40:17.615+0200 I/efl-extension( 3918): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 23:40:17.620+0200 I/efl-extension(  832): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 23:40:17.620+0200 I/efl-extension(  832): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x46070dd8, elm_box, time_stamp : 121800619
05-11 23:40:17.620+0200 I/wnotib  (  832): w-notification-board-broker-main.c: _wnotib_rotary_cb(559) > Pass rotary event to home.
05-11 23:40:17.620+0200 W/W_HOME  (  832): home_navigation.c: _rotary_cb(1168) > Detent detected, obj[0x46056f68], direction[0]
05-11 23:40:17.620+0200 E/W_HOME  (  832): home_navigation.c: _vi_init(954) > (scroller_info->vi_info.on == 1) -> _vi_init() return
05-11 23:40:17.620+0200 W/W_HOME  (  832): home_navigation.c: _nav_finish_timer_del(822) > delete timer
05-11 23:40:17.620+0200 W/W_HOME  (  832): home_navigation.c: _nav_finish_timer_add(850) > add timer:1
05-11 23:40:17.620+0200 W/W_HOME  (  832): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
05-11 23:40:17.620+0200 W/W_HOME  (  832): home_navigation.c: _is_rightedge(187) > (3600 360) not right edge: 0 0 0x4d39df00 -> 360 0 0x4d474750
05-11 23:40:17.630+0200 I/efl-extension(  832): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(633) > [0x46056f68 : elm_scroller] rotary callabck is called.
05-11 23:40:17.630+0200 I/efl-extension(  832): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(663) > [0x46056f68 : elm_scroller] block(2)
05-11 23:40:17.630+0200 I/efl-extension(  832): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(664) > [0x46056f68 : elm_scroller] scroll_locked_x(0), scroll_locked_y(0)
05-11 23:40:17.630+0200 I/efl-extension(  832): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(665) > [0x46056f68 : elm_scroller] content size (w, h)(8280, 360)
05-11 23:40:17.630+0200 I/efl-extension(  832): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(666) > [0x46056f68 : elm_scroller] viewport size (w, h)(360, 360)
05-11 23:40:17.630+0200 I/efl-extension(  832): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(730) > [0x46056f68 : elm_scroller] CurrentPage(10) DetentValue(1)
05-11 23:40:17.630+0200 I/efl-extension(  832): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(731) > [0x46056f68 : elm_scroller] DetentCount(0)
05-11 23:40:17.630+0200 I/efl-extension(  832): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(407) > [0x46056f68 : elm_scroller] mx(7920), my(0), minx(0), miny(0), px(3600), py(0)
05-11 23:40:17.630+0200 I/efl-extension(  832): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(407) > [0x46056f68 : elm_scroller] mx(7920), my(0), minx(0), miny(0), px(3600), py(0)
05-11 23:40:17.630+0200 I/efl-extension(  832): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(407) > [0x46056f68 : elm_scroller] mx(7920), my(0), minx(0), miny(0), px(3600), py(0)
05-11 23:40:17.630+0200 I/efl-extension(  832): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(763) > [0x46056f68 : elm_scroller] bring in 11 page
05-11 23:40:17.630+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:5560 _elm_scroll_page_bring_in() [0x46056f68 : elm_scroller] pagenumber_h(11), pagenumber_v(0)
05-11 23:40:17.630+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x46056f68 : elm_scroller] mx(7920), my(0), minx(0), miny(0), px(3600), py(0)
05-11 23:40:17.630+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x46056f68 : elm_scroller] cw(8280), ch(360), pw(360), ph(360)
05-11 23:40:17.630+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:1965 _elm_scroll_content_region_show_internal() [0x46056f68 : elm_scroller] x(3960), y(0), nx(3960), px(3600), ny(0) py(0)
05-11 23:40:17.630+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:1991 _elm_scroll_content_region_show_internal() [0x46056f68 : elm_scroller] x(3960), y(0)
05-11 23:40:17.630+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:5578 _elm_scroll_page_bring_in() [0x46056f68 : elm_scroller] _elm_scroll_content_region_show_internal() return TRUE!! x(3960), y(0)
05-11 23:40:17.630+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2676 _elm_scroll_scroll_to_x() [0x46056f68 : elm_scroller] t_in(0,270000), pos_x(3960)
05-11 23:40:17.630+0200 W/W_HOME  (  832): home_navigation.c: _anim_start_cb(1290) > anim start
05-11 23:40:17.630+0200 W/W_HOME  (  832): home_navigation.c: _nav_finish_timer_del(822) > delete timer
05-11 23:40:17.630+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2629 _elm_scroll_scroll_to_y() [0x46056f68 : elm_scroller] t_in(0,270000), pos_y(0)
05-11 23:40:17.630+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] time(0,153600)
05-11 23:40:17.630+0200 W/W_HOME  (  832): event_manager.c: _clock_view_obscured_cb(651) > state: 1 -> 0
05-11 23:40:17.630+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 3, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:40:17.630+0200 W/W_INDICATOR(  743): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
05-11 23:40:17.630+0200 W/W_INDICATOR(  743): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
05-11 23:40:17.630+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 3, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:40:17.630+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
05-11 23:40:17.630+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
05-11 23:40:17.635+0200 I/efl-extension( 4418): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 23:40:17.635+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_RENEW : px(3655), py(0)
05-11 23:40:17.635+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] time(0,153600)
05-11 23:40:17.635+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_RENEW : px(3655), py(0)
05-11 23:40:17.645+0200 I/efl-extension( 6230): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 23:40:17.655+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] time(0,259157)
05-11 23:40:17.665+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
05-11 23:40:17.665+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
05-11 23:40:17.665+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_RENEW : px(3693), py(0)
05-11 23:40:17.665+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] time(0,259157)
05-11 23:40:17.665+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_RENEW : px(3693), py(0)
05-11 23:40:17.680+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] time(0,388811)
05-11 23:40:17.680+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
05-11 23:40:17.680+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
05-11 23:40:17.680+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_RENEW : px(3739), py(0)
05-11 23:40:17.680+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] time(0,388811)
05-11 23:40:17.680+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_RENEW : px(3739), py(0)
05-11 23:40:17.705+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] time(0,529767)
05-11 23:40:17.705+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
05-11 23:40:17.705+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
05-11 23:40:17.705+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_RENEW : px(3790), py(0)
05-11 23:40:17.705+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] time(0,529767)
05-11 23:40:17.705+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_RENEW : px(3790), py(0)
05-11 23:40:17.730+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] time(0,649686)
05-11 23:40:17.730+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
05-11 23:40:17.730+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
05-11 23:40:17.730+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_RENEW : px(3833), py(0)
05-11 23:40:17.730+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] time(0,649686)
05-11 23:40:17.730+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_RENEW : px(3833), py(0)
05-11 23:40:17.750+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] time(0,737356)
05-11 23:40:17.750+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
05-11 23:40:17.750+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
05-11 23:40:17.755+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_RENEW : px(3865), py(0)
05-11 23:40:17.755+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] time(0,737356)
05-11 23:40:17.755+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_RENEW : px(3865), py(0)
05-11 23:40:17.775+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] time(0,814529)
05-11 23:40:17.775+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
05-11 23:40:17.775+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
05-11 23:40:17.780+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_RENEW : px(3893), py(0)
05-11 23:40:17.780+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] time(0,814529)
05-11 23:40:17.780+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_RENEW : px(3893), py(0)
05-11 23:40:17.790+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] time(0,860794)
05-11 23:40:17.790+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
05-11 23:40:17.790+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
05-11 23:40:17.790+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_RENEW : px(3909), py(0)
05-11 23:40:17.790+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] time(0,860794)
05-11 23:40:17.790+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_RENEW : px(3909), py(0)
05-11 23:40:17.810+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] time(0,915017)
05-11 23:40:17.810+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
05-11 23:40:17.810+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
05-11 23:40:17.810+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_RENEW : px(3929), py(0)
05-11 23:40:17.810+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] time(0,915017)
05-11 23:40:17.815+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_RENEW : px(3929), py(0)
05-11 23:40:17.825+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] time(0,946111)
05-11 23:40:17.825+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
05-11 23:40:17.825+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
05-11 23:40:17.830+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_RENEW : px(3940), py(0)
05-11 23:40:17.830+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] time(0,946111)
05-11 23:40:17.830+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_RENEW : px(3940), py(0)
05-11 23:40:17.845+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] time(0,973858)
05-11 23:40:17.845+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
05-11 23:40:17.845+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
05-11 23:40:17.845+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_RENEW : px(3950), py(0)
05-11 23:40:17.845+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] time(0,973858)
05-11 23:40:17.850+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_RENEW : px(3950), py(0)
05-11 23:40:17.860+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] time(0,986976)
05-11 23:40:17.860+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
05-11 23:40:17.860+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
05-11 23:40:17.865+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_RENEW : px(3955), py(0)
05-11 23:40:17.865+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] time(0,986976)
05-11 23:40:17.870+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_RENEW : px(3955), py(0)
05-11 23:40:17.880+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] time(0,999233)
05-11 23:40:17.885+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
05-11 23:40:17.885+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
05-11 23:40:17.895+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_RENEW : px(3959), py(0)
05-11 23:40:17.895+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] time(0,999233)
05-11 23:40:17.895+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_RENEW : px(3959), py(0)
05-11 23:40:17.910+0200 I/CAPI_WIDGET_APPLICATION(22748): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
05-11 23:40:17.910+0200 W/AUL     (22748): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.app-widget.widget) pid(22748) status(fg) type(widgetapp)
05-11 23:40:17.910+0200 I/CAPI_WIDGET_APPLICATION(22748): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
05-11 23:40:17.915+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] time(0,990309)
05-11 23:40:17.915+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
05-11 23:40:17.915+0200 I/ELM_RPANEL(  832): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
05-11 23:40:17.925+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_CANCEL : px(3960), py(0)
05-11 23:40:17.925+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] time(0,990309)
05-11 23:40:17.925+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] animation stop!!
05-11 23:40:17.925+0200 W/wnotib  (  832): w-notification-board-panel-manager.c: _wnb_pm_anim_stop_cb(96) > notiboard scroller anim stop [3960][0][360][360]
05-11 23:40:17.925+0200 W/wnotib  (  832): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(969) > No postponed update with is_for_VI: 1.
05-11 23:40:17.925+0200 W/W_HOME  (  832): home_navigation.c: _anim_stop_cb(1316) > anim stop
05-11 23:40:17.925+0200 W/W_HOME  (  832): home_navigation.c: _nav_finish_timer_del(822) > delete timer
05-11 23:40:17.925+0200 W/W_HOME  (  832): home_navigation.c: _nav_finish_timer_add(850) > add timer:1
05-11 23:40:17.925+0200 W/W_HOME  (  832): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
05-11 23:40:17.925+0200 I/efl-extension(  832): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(489) > [0x46056f68 : elm_scroller] detent_count(1)
05-11 23:40:17.925+0200 I/efl-extension(  832): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(490) > [0x46056f68 : elm_scroller] pagenumber_v(0), pagenumber_h(11)
05-11 23:40:17.925+0200 I/efl-extension(  832): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(512) > [0x46056f68 : elm_scroller] CurrentPage(11)
05-11 23:40:17.925+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x46056f68 : elm_scroller] ECORE_CALLBACK_CANCEL : px(3960), py(0)
05-11 23:40:17.940+0200 W/WATCH_CORE( 3611): appcore-watch.c: __widget_pause(1113) > widget_pause
05-11 23:40:17.940+0200 W/AUL     ( 3611): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(F1avfmJXBt.CyberWatch) pid(3611) status(bg) type(watchapp)
05-11 23:40:18.055+0200 E/W_HOME  (  832): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
05-11 23:40:18.075+0200 W/W_HOME  (  832): event_manager.c: _home_scroll_cb(585) > scroll,will,done
05-11 23:40:18.075+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:40:18.075+0200 W/W_HOME  (  832): event_manager.c: _home_scroll_cb(585) > scroll,done
05-11 23:40:18.075+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:40:18.160+0200 E/EFL     (  832): ecore_x<832> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=121801170 button=1
05-11 23:40:18.160+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056f68 : elm_scroller] mouse move
05-11 23:40:18.165+0200 W/W_HOME  (  832): home_navigation.c: _nav_finish_timer_del(822) > delete timer
05-11 23:40:18.175+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056f68 : elm_scroller] mouse move
05-11 23:40:18.175+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056f68 : elm_scroller] hold(0), freeze(0)
05-11 23:40:18.180+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056f68 : elm_scroller] mouse move
05-11 23:40:18.180+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056f68 : elm_scroller] hold(0), freeze(0)
05-11 23:40:18.195+0200 E/EFL     (22748): evas_main<22748> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
05-11 23:40:18.195+0200 E/EFL     (22748): evas_main<22748> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
05-11 23:40:18.195+0200 E/EFL     (22748): evas_main<22748> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
05-11 23:40:18.195+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056f68 : elm_scroller] mouse move
05-11 23:40:18.195+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056f68 : elm_scroller] hold(0), freeze(0)
05-11 23:40:18.205+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056f68 : elm_scroller] mouse move
05-11 23:40:18.205+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056f68 : elm_scroller] hold(0), freeze(0)
05-11 23:40:18.220+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056f68 : elm_scroller] mouse move
05-11 23:40:18.220+0200 E/EFL     (  832): elementary<832> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056f68 : elm_scroller] hold(0), freeze(0)
05-11 23:40:18.230+0200 E/EFL     (  832): ecore_x<832> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=121801235 button=1
05-11 23:40:18.230+0200 W/W_HOME  (  832): home_navigation.c: _up_cb(1247) > up
05-11 23:40:18.230+0200 W/W_HOME  (  832): home_navigation.c: _nav_finish_timer_del(822) > delete timer
05-11 23:40:18.230+0200 W/W_HOME  (  832): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
05-11 23:40:18.255+0200 W/AUL     (22748): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.scorekeeperforgear)
05-11 23:40:18.255+0200 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
05-11 23:40:18.260+0200 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 22748
05-11 23:40:18.260+0200 I/AUL_AMD (  507): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
05-11 23:40:18.275+0200 E/RESOURCED(  624): block.c: block_prelaunch_state(138) > insert data org.example.scorekeeperforgear, table num : 19
05-11 23:40:18.280+0200 W/AUL_AMD (  507): amd_launch.c: _start_app(2218) > pad pid(-5)
05-11 23:40:18.280+0200 W/AUL_PAD ( 1315): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
05-11 23:40:18.280+0200 W/AUL_PAD ( 1315): launchpad.c: __send_result_to_caller(272) > Check app launching
05-11 23:40:18.280+0200 W/AUL_PAD (14377): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
05-11 23:40:18.285+0200 W/AUL_PAD (14377): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
05-11 23:40:18.285+0200 W/AUL_PAD (14377): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
05-11 23:40:18.285+0200 W/AUL_PAD (14377): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.scorekeeperforgear)
05-11 23:40:18.350+0200 I/efl-extension(14377): efl_extension.c: eext_mod_init(40) > Init
05-11 23:40:18.355+0200 I/UXT     (14377): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
05-11 23:40:18.370+0200 W/AUL_PAD (14377): launchpad_loader.c: main(690) > [candidate] dlsym
05-11 23:40:18.370+0200 W/AUL_PAD (14377): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.scorekeeperforgear)
05-11 23:40:18.370+0200 I/CAPI_APPFW_APPLICATION(14377): app_main.c: ui_app_main(704) > app_efl_main
05-11 23:40:18.370+0200 I/CAPI_APPFW_APPLICATION(14377): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-11 23:40:18.380+0200 W/AUL     (  507): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.scorekeeperforgear) pid(14377) type(uiapp) bg(2)
05-11 23:40:18.385+0200 W/AUL_AMD (  507): amd_status.c: __socket_monitor_cb(1277) > (14377) was created
05-11 23:40:18.385+0200 E/AUL     (  507): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-11 23:40:18.385+0200 W/AUL     (22748): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14377)
05-11 23:40:18.385+0200 E/APP_SHORTCUT_WIDGET(22748): main.c: _tts_button_mouse_clicked_cb(732) >  (tts_status == 0) -> _tts_button_mouse_clicked_cb() return
05-11 23:40:18.435+0200 W/STARTER (  742): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [14377]
05-11 23:40:18.535+0200 I/efl-extension(14377): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1242) > Put the surface[0x417f0868]'s widget[0x417fbcd0] to elm_conformant widget[0x417bec20]
05-11 23:40:18.540+0200 I/efl-extension(14377): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
05-11 23:40:18.545+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_add(1990) > called!!
05-11 23:40:18.565+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: _eext_rotary_selector_data_init(586) > rsd is initialized!!
05-11 23:40:18.600+0200 I/efl-extension(14377): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-11 23:40:18.600+0200 I/efl-extension(14377): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-11 23:40:18.600+0200 I/efl-extension(14377): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-11 23:40:18.605+0200 I/efl-extension(14377): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-11 23:40:18.605+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: _event_area_callback_add(500) > called!!
05-11 23:40:18.605+0200 I/efl-extension(14377): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x417fcfe8, elm_layout, _activated_obj : 0x0, activated : 1
05-11 23:40:18.605+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
05-11 23:40:18.620+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
05-11 23:40:18.630+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
05-11 23:40:18.630+0200 E/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
05-11 23:40:18.630+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
05-11 23:40:18.630+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
05-11 23:40:18.630+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
05-11 23:40:18.630+0200 E/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
05-11 23:40:18.630+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
05-11 23:40:18.635+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
05-11 23:40:18.635+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
05-11 23:40:18.635+0200 E/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
05-11 23:40:18.635+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
05-11 23:40:18.640+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
05-11 23:40:18.640+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
05-11 23:40:18.640+0200 E/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
05-11 23:40:18.640+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
05-11 23:40:18.645+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
05-11 23:40:18.645+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
05-11 23:40:18.645+0200 E/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
05-11 23:40:18.645+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
05-11 23:40:18.645+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
05-11 23:40:18.645+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
05-11 23:40:18.645+0200 E/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
05-11 23:40:18.645+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
05-11 23:40:18.650+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
05-11 23:40:18.650+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
05-11 23:40:18.650+0200 E/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
05-11 23:40:18.650+0200 E/EFL     (14377): elementary<14377> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
05-11 23:40:18.660+0200 E/EFL     (14377): elementary<14377> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x4446e7d8) will be pushed
05-11 23:40:18.675+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: _rotary_selector_show_cb(805) > called!!
05-11 23:40:18.680+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: _rotary_selector_move_cb(776) > called!!
05-11 23:40:18.725+0200 W/W_HOME  (  832): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
05-11 23:40:18.725+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:40:18.725+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:40:18.725+0200 W/W_INDICATOR(  743): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
05-11 23:40:18.725+0200 W/W_INDICATOR(  743): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
05-11 23:40:18.745+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:40:18.745+0200 W/W_HOME  (  832): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
05-11 23:40:18.745+0200 I/APP_CORE(14377): appcore-efl.c: __do_app(453) > [APP 14377] Event: RESET State: CREATED
05-11 23:40:18.745+0200 I/CAPI_APPFW_APPLICATION(14377): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-11 23:40:18.750+0200 W/W_HOME  (  832): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
05-11 23:40:18.765+0200 I/APP_CORE(14377): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
05-11 23:40:18.765+0200 I/APP_CORE(14377): appcore-efl.c: __do_app(524) > [APP 14377] Initial Launching, call the resume_cb
05-11 23:40:18.765+0200 I/CAPI_APPFW_APPLICATION(14377): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-11 23:40:18.770+0200 I/MALI    (  832): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43ecf100] swap changed from sync to async
05-11 23:40:18.780+0200 W/APP_CORE(14377): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:8c00002
05-11 23:40:18.785+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: _rotary_selector_move_cb(776) > called!!
05-11 23:40:18.785+0200 I/efl-extension(14377): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(649) > surface 0x417f0868 = w: 1 h: 1  obj 0x417fbcd0 w: 360 h: 360
05-11 23:40:18.785+0200 I/efl-extension(14377): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(673) > Surface will be initialized! surface->w= 360 surface->h = 360
05-11 23:40:18.795+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: _item_update_animator_cb(1414) > called
05-11 23:40:18.795+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: _item_update_animator_cb(1423) > item_list(0x1145270272), count(7)
05-11 23:40:18.925+0200 W/W_HOME  (  832): event_manager.c: _window_visibility_cb(466) > Window [0x2E00003] is now visible(1)
05-11 23:40:18.925+0200 W/W_HOME  (  832): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
05-11 23:40:18.925+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:40:18.925+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:40:18.925+0200 I/APP_CORE(14377): appcore-efl.c: __do_app(453) > [APP 14377] Event: RESUME State: RUNNING
05-11 23:40:18.930+0200 E/W_HOME  (  832): win.c: win_rotation_disable_set(186) > failed to get key VCONFKEY_DISABLE_ROTATION
05-11 23:40:18.930+0200 W/W_HOME  (  832): main.c: _window_visibility_cb(963) > Window [0x2E00003] is now visible(1)
05-11 23:40:18.930+0200 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(832) status(bg) type(uiapp)
05-11 23:40:18.935+0200 W/STARTER (  742): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[832] goes to (4)
05-11 23:40:18.935+0200 E/STARTER (  742): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 832)'s state(4)
05-11 23:40:18.940+0200 W/STARTER (  742): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[14377] goes to (3)
05-11 23:40:18.940+0200 W/AUL_AMD (  507): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-11 23:40:18.940+0200 W/AUL_AMD (  507): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-11 23:40:18.940+0200 I/APP_CORE(  832): appcore-efl.c: __do_app(453) > [APP 832] Event: PAUSE State: RUNNING
05-11 23:40:18.940+0200 I/CAPI_APPFW_APPLICATION(  832): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-11 23:40:18.940+0200 W/W_HOME  (  832): main.c: _appcore_pause_cb(487) > appcore pause
05-11 23:40:18.940+0200 W/W_HOME  (  832): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
05-11 23:40:18.940+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:40:18.940+0200 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.scorekeeperforgear) pid(14377) status(fg) type(uiapp)
05-11 23:40:18.940+0200 W/W_INDICATOR(  743): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
05-11 23:40:18.940+0200 W/W_INDICATOR(  743): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
05-11 23:40:18.945+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:40:18.945+0200 W/W_HOME  (  832): main.c: home_pause(546) > clock/widget paused
05-11 23:40:18.945+0200 W/W_HOME  (  832): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 23:40:18.945+0200 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-11 23:40:18.945+0200 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-11 23:40:18.945+0200 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-11 23:40:18.945+0200 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-11 23:40:18.945+0200 I/MESSAGE_PORT(  483): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-11 23:40:18.945+0200 I/MESSAGE_PORT(  483): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-11 23:40:18.945+0200 I/MESSAGE_PORT(  483): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-11 23:40:18.945+0200 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-11 23:40:18.945+0200 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-11 23:40:18.945+0200 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-11 23:40:18.945+0200 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-11 23:40:18.945+0200 I/MESSAGE_PORT(  483): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-11 23:40:18.945+0200 I/MESSAGE_PORT(  483): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-11 23:40:18.945+0200 I/MESSAGE_PORT(  483): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-11 23:40:18.945+0200 I/MESSAGE_PORT(  483): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-11 23:40:18.945+0200 I/MESSAGE_PORT(  483): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-11 23:40:18.945+0200 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-11 23:40:18.945+0200 I/MESSAGE_PORT(  483): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-11 23:40:18.950+0200 I/wnotib  (  832): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
05-11 23:40:18.950+0200 E/wnotib  (  832): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-11 23:40:18.950+0200 W/wnotib  (  832): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [225], notiboard card appending count [444].
05-11 23:40:18.950+0200 E/CAPI_APPFW_APP_CONTROL(22830): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-11 23:40:18.950+0200 W/MUSIC_CONTROL_SERVICE(22830): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:22830]   [com.samsung.w-home]register msg port [false][0m
05-11 23:40:18.950+0200 E/TBM     (  470): tbm_bufmgr.c: _tgl_destroy(141) > [libtbm:470] error(Device or resource busy) _tgl_destroy:141 key:61
05-11 23:40:18.975+0200 E/APP_SHORTCUT_WIDGET(22748): main.c: widget_instance_pause(1669) >  (!popup) -> widget_instance_pause() return
05-11 23:40:18.975+0200 I/CAPI_WIDGET_APPLICATION(22748): widget_app.c: __provider_pause_cb(298) > widget obj was paused
05-11 23:40:18.975+0200 W/AUL     (22748): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.app-widget.widget) pid(22748) status(bg) type(widgetapp)
05-11 23:40:18.980+0200 I/CAPI_WIDGET_APPLICATION(22748): widget_app.c: __check_status_for_cgroup(145) > enter background group
05-11 23:40:19.315+0200 E/TBM     (  470): tbm_bufmgr.c: _tgl_destroy(141) > [libtbm:470] error(Device or resource busy) _tgl_destroy:141 key:92
05-11 23:40:19.320+0200 E/AUL     (  507): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-11 23:40:19.450+0200 I/APP_CORE(  832): appcore-efl.c: __do_app(453) > [APP 832] Event: MEM_FLUSH State: PAUSED
05-11 23:40:19.575+0200 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 14
05-11 23:40:19.585+0200 W/AUL_AMD (  507): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14377
05-11 23:40:19.585+0200 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 14
05-11 23:40:19.590+0200 W/AUL_AMD (  507): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14377
05-11 23:40:19.595+0200 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 12
05-11 23:40:19.600+0200 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 12
05-11 23:40:19.825+0200 E/WMS     (  515): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23483) > _wms_event_handler_cb_nomove_detector is called
05-11 23:40:20.725+0200 I/AUL_PAD (14426): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-11 23:40:20.965+0200 E/EFL     (14377): ecore_x<14377> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=121803976 button=1
05-11 23:40:21.180+0200 E/EFL     (14377): ecore_x<14377> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=121804119 button=1
05-11 23:40:21.390+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: _selector_clicked_signal(1784) > called!!
05-11 23:40:21.390+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_selected_item_get(2961) > called!!
05-11 23:40:21.390+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_get(2370) > called!!
05-11 23:40:21.390+0200 I/efl-extension(14377): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_get(2370) > called!!
05-11 23:40:21.550+0200 W/CRASH_MANAGER(14406): worker.c: worker_job(1205) > 111437773636f149453882
