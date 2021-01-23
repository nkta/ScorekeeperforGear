S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.2
Build-Number: R732XXU2EQC1
Build-Date: 2017.03.13 20:32:41

Crash Information
Process Name: scorekeeperforgear
PID: 17812
Date: 2017-06-25 11:06:17+0200
Executable File Path: /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 17812, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x4015acf9
r4   = 0xbedb223c, r5   = 0xfffeed59
r6   = 0x418cbb2c, r7   = 0xbedb2330
r8   = 0x00000284, r9   = 0x413c87d8
r10  = 0x4031fb10, fp   = 0x00000000
ip   = 0x41454070, sp   = 0xbedb20c8
lr   = 0x418b659b, pc   = 0x418b65a0
cpsr = 0x60000030

Memory Information
MemTotal:   491132 KB
MemFree:      5644 KB
Buffers:      4616 KB
Cached:      82424 KB
VmPeak:     136796 KB
VmSize:     136284 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       37180 KB
VmRSS:       37176 KB
VmData:      73864 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25440 KB
VmPTE:          78 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 17812 TID = 17812
17812 17886 17896 17897 17898 

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
414be000 414c9000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
414d4000 414d8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
414e1000 414e3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
414ec000 414f2000 r-xp /usr/lib/libappsvc.so.0.1.0
414fa000 4151e000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41527000 415f6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4160c000 41616000 r-xp /lib/libnss_files-2.13.so
418b2000 418bc000 r-xp /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
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
43bbf000 43bca000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43bd3000 43bd8000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43be0000 43bf7000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43c04000 43c06000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43c0f000 4440e000 rw-p [stack:17897]
4440e000 4440f000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
444de000 444df000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
44601000 44f01000 rw-p [stack:17886]
44f01000 44f09000 r-xp /usr/lib/libfeedback.so.0.1.4
44f0b000 44f0c000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44f14000 44f16000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
44f1e000 44f29000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
44f31000 44f38000 r-xp /usr/lib/libmmfcommon.so.0.0.0
44f40000 44f58000 r-xp /usr/lib/libmmfsound.so.0.1.0
44f69000 44f6d000 r-xp /usr/lib/libmmfsession.so.0.0.0
44f76000 44f81000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
44f8e000 44f92000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
44f9a000 44fb0000 r-xp /usr/lib/libavsysaudio.so.0.0.1
44fb8000 45019000 r-xp /usr/lib/libasound.so.2.0.0
45023000 45026000 r-xp /usr/lib/libpulse-simple.so.0.0.4
4502e000 45066000 r-xp /usr/lib/libpulse.so.0.16.2
45067000 4506a000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
45073000 45a98000 rw-p [stack:17896]
45a98000 45ae0000 r-xp /usr/lib/libmdm.so.1.2.62
4682c000 4682f000 r-xp /usr/lib/libtinycompress.so.0.0.0
46837000 4683c000 r-xp /usr/lib/libjson.so.0.0.1
46844000 4688d000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46896000 468dd000 r-xp /usr/lib/libsndfile.so.1.0.26
468e9000 468ed000 r-xp /usr/lib/libogg.so.0.7.1
46a01000 47200000 rw-p [stack:17898]
48200000 4820f000 r-xp /usr/lib/libmdm-common.so.1.1.22
48218000 4823a000 r-xp /usr/lib/libvorbis.so.0.4.3
bed92000 bedb3000 rw-p [stack]
End of Maps Information

Callstack Information (PID:17812)
Call Stack Count: 11
 0: _progressbar_timer_cb_1(void*) + 0x77 (0x418b65a0) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x45a0
 1: (0x403011f9) [/usr/lib/libecore.so.1] + 0xf1f9
 2: (0x403012ef) [/usr/lib/libecore.so.1] + 0xf2ef
 3: (0x402fe2f3) [/usr/lib/libecore.so.1] + 0xc2f3
 4: ecore_main_loop_begin + 0x30 (0x402fe879) [/usr/lib/libecore.so.1] + 0xc879
 5: appcore_efl_main + 0x332 (0x40044b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
 6: ui_app_main + 0xb0 (0x41492421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 7: main + 0xc2 (0x418b56eb) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x36eb
 8:  + 0x0 (0x40001a53) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x1a53
 9: __libc_start_main + 0x114 (0x4049485c) [/lib/libc.so.6] + 0x1785c
10: (0x40001e0c) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x1e0c
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
_scroll_to_x_animator() [0x46056f58 : elm_scroller] time(0,740145)
06-25 11:06:14.212+0200 W/WRT_PLUGINS/TIZEN(17384): SystemInfoCpu.cpp: fetchLoad(76) > Cannot calculate cpu load, previous value returned
06-25 11:06:14.212+0200 I/ELM_RPANEL(  840): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-25 11:06:14.212+0200 I/ELM_RPANEL(  840): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-25 11:06:14.217+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(4773), py(0)
06-25 11:06:14.217+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] time(0,740145)
06-25 11:06:14.217+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(4773), py(0)
06-25 11:06:14.222+0200 W/LIVE_MUSIC_PLAYER(  999): mp-albumart-transition.c: _mp_albumart_label_transition(404) > [33m[TID:999]   title [BT déconnecté]->[BT déconnecté][0m
06-25 11:06:14.222+0200 W/LIVE_MUSIC_PLAYER(  999): mp-albumart-transition.c: _mp_albumart_label_transition(421) > [33m[TID:999]   same title, artist[0m
06-25 11:06:14.227+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] time(0,805312)
06-25 11:06:14.227+0200 I/ELM_RPANEL(  840): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-25 11:06:14.227+0200 I/ELM_RPANEL(  840): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-25 11:06:14.232+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(4750), py(0)
06-25 11:06:14.232+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] time(0,805312)
06-25 11:06:14.232+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(4750), py(0)
06-25 11:06:14.242+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] time(0,850309)
06-25 11:06:14.242+0200 I/ELM_RPANEL(  840): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-25 11:06:14.242+0200 I/ELM_RPANEL(  840): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-25 11:06:14.242+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(4733), py(0)
06-25 11:06:14.242+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] time(0,850309)
06-25 11:06:14.242+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(4733), py(0)
06-25 11:06:14.262+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] time(0,898208)
06-25 11:06:14.262+0200 I/ELM_RPANEL(  840): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-25 11:06:14.262+0200 I/ELM_RPANEL(  840): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-25 11:06:14.262+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(4716), py(0)
06-25 11:06:14.262+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] time(0,898208)
06-25 11:06:14.262+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(4716), py(0)
06-25 11:06:14.277+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] time(0,932806)
06-25 11:06:14.277+0200 I/ELM_RPANEL(  840): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-25 11:06:14.277+0200 I/ELM_RPANEL(  840): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-25 11:06:14.277+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(4704), py(0)
06-25 11:06:14.277+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] time(0,932806)
06-25 11:06:14.277+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(4704), py(0)
06-25 11:06:14.292+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] time(0,956123)
06-25 11:06:14.292+0200 I/ELM_RPANEL(  840): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-25 11:06:14.292+0200 I/ELM_RPANEL(  840): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-25 11:06:14.292+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(4695), py(0)
06-25 11:06:14.292+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] time(0,956123)
06-25 11:06:14.292+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(4695), py(0)
06-25 11:06:14.302+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] time(0,975928)
06-25 11:06:14.307+0200 I/ELM_RPANEL(  840): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-25 11:06:14.307+0200 I/ELM_RPANEL(  840): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-25 11:06:14.307+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(4688), py(0)
06-25 11:06:14.307+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] time(0,975928)
06-25 11:06:14.307+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(4688), py(0)
06-25 11:06:14.332+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] time(0,996293)
06-25 11:06:14.332+0200 I/ELM_RPANEL(  840): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-25 11:06:14.332+0200 I/ELM_RPANEL(  840): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-25 11:06:14.332+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(4681), py(0)
06-25 11:06:14.332+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] time(0,996293)
06-25 11:06:14.332+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_RENEW : px(4681), py(0)
06-25 11:06:14.357+0200 I/CAPI_WIDGET_APPLICATION(  993): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
06-25 11:06:14.357+0200 W/AUL     (  993): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.app-widget.widget) pid(993) status(fg) type(widgetapp)
06-25 11:06:14.357+0200 I/CAPI_WIDGET_APPLICATION(  993): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
06-25 11:06:14.362+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] time(0,996092)
06-25 11:06:14.367+0200 I/ELM_RPANEL(  840): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-25 11:06:14.367+0200 I/ELM_RPANEL(  840): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-25 11:06:14.367+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_CANCEL : px(4680), py(0)
06-25 11:06:14.367+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] time(0,996092)
06-25 11:06:14.367+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] animation stop!!
06-25 11:06:14.367+0200 W/wnotib  (  840): w-notification-board-panel-manager.c: _wnb_pm_anim_stop_cb(96) > notiboard scroller anim stop [4680][0][360][360]
06-25 11:06:14.367+0200 W/wnotib  (  840): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(969) > No postponed update with is_for_VI: 1.
06-25 11:06:14.367+0200 W/W_HOME  (  840): home_navigation.c: _anim_stop_cb(1316) > anim stop
06-25 11:06:14.367+0200 W/W_HOME  (  840): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-25 11:06:14.367+0200 W/W_HOME  (  840): home_navigation.c: _nav_finish_timer_add(850) > add timer:1
06-25 11:06:14.367+0200 W/W_HOME  (  840): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
06-25 11:06:14.367+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(489) > [0x46056f58 : elm_scroller] detent_count(-1)
06-25 11:06:14.367+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(490) > [0x46056f58 : elm_scroller] pagenumber_v(0), pagenumber_h(13)
06-25 11:06:14.367+0200 I/efl-extension(  840): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(512) > [0x46056f58 : elm_scroller] CurrentPage(13)
06-25 11:06:14.367+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x46056f58 : elm_scroller] ECORE_CALLBACK_CANCEL : px(4680), py(0)
06-25 11:06:14.407+0200 W/LIVE_MUSIC_PLAYER(  999): dbox-mp-main.c: _widget_mp_instance_pause(1831) > [36m[TID:999]   [MUSIC_PLAYER_EVENT]pause[0m
06-25 11:06:14.412+0200 W/LIVE_MUSIC_PLAYER(  999): dbox-mp-control.c: widget_mp_control_view_pause(465) > [36m[TID:999]   [MUSIC_PLAYER_EVENT][0m
06-25 11:06:14.412+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-25 11:06:14.412+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-25 11:06:14.412+0200 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-25 11:06:14.412+0200 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-25 11:06:14.412+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-25 11:06:14.412+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-25 11:06:14.412+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-25 11:06:14.412+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-25 11:06:14.412+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-25 11:06:14.412+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-25 11:06:14.412+0200 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-25 11:06:14.412+0200 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-25 11:06:14.412+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-25 11:06:14.412+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-25 11:06:14.412+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-25 11:06:14.412+0200 I/MESSAGE_PORT(  481): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-25 11:06:14.412+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-25 11:06:14.412+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-25 11:06:14.412+0200 E/CAPI_APPFW_APP_CONTROL( 1257): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-25 11:06:14.412+0200 W/MUSIC_CONTROL_SERVICE( 1257): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1257]   [com.samsung.w-music-player.widget]register msg port [false][0m
06-25 11:06:14.412+0200 W/AUL_AMD (  506): amd_request.c: __request_handler(669) > __request_handler: 14
06-25 11:06:14.417+0200 W/AUL_AMD (  506): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 840
06-25 11:06:14.422+0200 I/CAPI_WIDGET_APPLICATION(  999): widget_app.c: __provider_pause_cb(298) > widget obj was paused
06-25 11:06:14.422+0200 W/AUL     (  999): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-music-player.widget) pid(999) status(bg) type(widgetapp)
06-25 11:06:14.422+0200 I/CAPI_WIDGET_APPLICATION(  999): widget_app.c: __check_status_for_cgroup(145) > enter background group
06-25 11:06:14.487+0200 E/W_HOME  (  840): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
06-25 11:06:14.487+0200 E/EFL     (  840): edje<840> edje_util.c:3785 edje_object_size_min_restricted_calc() group page has a non-fixed part 'bg'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-25 11:06:14.487+0200 E/EFL     (  840): edje<840> edje_util.c:3785 edje_object_size_min_restricted_calc() group page has a non-fixed part 'bg'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-25 11:06:14.487+0200 E/EFL     (  840): edje<840> edje_util.c:3788 edje_object_size_min_restricted_calc() group page overflowed 4000x4000 with minimum size of 4320x360. Continuing discarding faulty parts.
06-25 11:06:14.497+0200 W/W_HOME  (  840): event_manager.c: _home_scroll_cb(585) > scroll,will,done
06-25 11:06:14.502+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 11:06:14.502+0200 W/W_HOME  (  840): event_manager.c: _home_scroll_cb(585) > scroll,done
06-25 11:06:14.502+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 11:06:14.867+0200 W/W_HOME  (  840): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
06-25 11:06:14.867+0200 E/EFL     (  840): ecore_x<840> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=16667123 button=1
06-25 11:06:14.872+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056f58 : elm_scroller] mouse move
06-25 11:06:14.872+0200 W/W_HOME  (  840): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-25 11:06:14.912+0200 E/EFL     (  993): evas_main<993> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
06-25 11:06:14.912+0200 E/EFL     (  993): evas_main<993> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
06-25 11:06:14.912+0200 E/EFL     (  993): evas_main<993> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
06-25 11:06:14.967+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056f58 : elm_scroller] mouse move
06-25 11:06:14.967+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056f58 : elm_scroller] hold(0), freeze(0)
06-25 11:06:14.972+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056f58 : elm_scroller] mouse move
06-25 11:06:14.972+0200 E/EFL     (  840): elementary<840> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056f58 : elm_scroller] hold(0), freeze(0)
06-25 11:06:14.982+0200 E/EFL     (  840): ecore_x<840> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=16667230 button=1
06-25 11:06:14.982+0200 W/W_HOME  (  840): home_navigation.c: _up_cb(1247) > up
06-25 11:06:14.982+0200 W/W_HOME  (  840): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-25 11:06:14.982+0200 W/W_HOME  (  840): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
06-25 11:06:15.007+0200 W/AUL     (  993): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.scorekeeperforgear)
06-25 11:06:15.007+0200 W/AUL_AMD (  506): amd_request.c: __request_handler(669) > __request_handler: 0
06-25 11:06:15.012+0200 W/AUL_AMD (  506): amd_launch.c: _start_app(1782) > caller pid : 993
06-25 11:06:15.012+0200 I/AUL_AMD (  506): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
06-25 11:06:15.032+0200 W/AUL_AMD (  506): amd_launch.c: _start_app(2218) > pad pid(-5)
06-25 11:06:15.032+0200 W/AUL_PAD ( 1356): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
06-25 11:06:15.032+0200 W/AUL_PAD ( 1356): launchpad.c: __send_result_to_caller(272) > Check app launching
06-25 11:06:15.037+0200 W/AUL_PAD (17812): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
06-25 11:06:15.037+0200 E/RESOURCED(  598): block.c: block_prelaunch_state(138) > insert data org.example.scorekeeperforgear, table num : 7
06-25 11:06:15.037+0200 W/AUL_PAD (17812): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
06-25 11:06:15.037+0200 W/AUL_PAD (17812): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
06-25 11:06:15.037+0200 W/AUL_PAD (17812): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.scorekeeperforgear)
06-25 11:06:15.087+0200 I/AUL     (17384): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
06-25 11:06:15.107+0200 I/efl-extension(17812): efl_extension.c: eext_mod_init(40) > Init
06-25 11:06:15.112+0200 I/UXT     (17812): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
06-25 11:06:15.127+0200 W/AUL_PAD (17812): launchpad_loader.c: main(690) > [candidate] dlsym
06-25 11:06:15.127+0200 W/AUL_PAD (17812): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.scorekeeperforgear)
06-25 11:06:15.137+0200 I/CAPI_APPFW_APPLICATION(17812): app_main.c: ui_app_main(704) > app_efl_main
06-25 11:06:15.142+0200 I/CAPI_APPFW_APPLICATION(17812): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
06-25 11:06:15.207+0200 W/WRT_PLUGINS/TIZEN(17384): SystemInfoCpu.cpp: fetchLoad(76) > Cannot calculate cpu load, previous value returned
06-25 11:06:15.237+0200 W/AUL     (  506): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.scorekeeperforgear) pid(17812) type(uiapp) bg(2)
06-25 11:06:15.237+0200 W/AUL_AMD (  506): amd_status.c: __socket_monitor_cb(1277) > (17812) was created
06-25 11:06:15.237+0200 W/AUL     (  993): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17812)
06-25 11:06:15.237+0200 E/AUL     (  506): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
06-25 11:06:15.237+0200 E/APP_SHORTCUT_WIDGET(  993): main.c: _tts_button_mouse_clicked_cb(732) >  (tts_status == 0) -> _tts_button_mouse_clicked_cb() return
06-25 11:06:15.242+0200 W/STARTER (  755): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [17812]
06-25 11:06:15.267+0200 I/efl-extension(17812): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1242) > Put the surface[0x417f14b8]'s widget[0x417fbc70] to elm_conformant widget[0x417beca8]
06-25 11:06:15.267+0200 I/efl-extension(17812): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
06-25 11:06:15.272+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_add(1990) > called!!
06-25 11:06:15.287+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: _eext_rotary_selector_data_init(586) > rsd is initialized!!
06-25 11:06:15.317+0200 I/efl-extension(17812): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
06-25 11:06:15.317+0200 I/efl-extension(17812): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
06-25 11:06:15.317+0200 I/efl-extension(17812): efl_extension_rotary.c: _init_Xi2_system(314) > In
06-25 11:06:15.317+0200 I/efl-extension(17812): efl_extension_rotary.c: _init_Xi2_system(375) > Done
06-25 11:06:15.317+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: _event_area_callback_add(500) > called!!
06-25 11:06:15.322+0200 I/efl-extension(17812): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x417fcf88, elm_layout, _activated_obj : 0x0, activated : 1
06-25 11:06:15.322+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 11:06:15.337+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 11:06:15.337+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 11:06:15.337+0200 E/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 11:06:15.337+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 11:06:15.342+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 11:06:15.342+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 11:06:15.342+0200 E/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 11:06:15.342+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 11:06:15.342+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 11:06:15.347+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 11:06:15.347+0200 E/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 11:06:15.347+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 11:06:15.347+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 11:06:15.347+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 11:06:15.347+0200 E/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 11:06:15.347+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 11:06:15.352+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 11:06:15.352+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 11:06:15.352+0200 E/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 11:06:15.352+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 11:06:15.357+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 11:06:15.357+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 11:06:15.357+0200 E/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 11:06:15.357+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 11:06:15.362+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 11:06:15.362+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 11:06:15.362+0200 E/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 11:06:15.362+0200 E/EFL     (17812): elementary<17812> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
06-25 11:06:15.372+0200 E/EFL     (17812): elementary<17812> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x4456be50) will be pushed
06-25 11:06:15.387+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: _rotary_selector_show_cb(805) > called!!
06-25 11:06:15.392+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: _rotary_selector_move_cb(776) > called!!
06-25 11:06:15.427+0200 W/W_HOME  (  840): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
06-25 11:06:15.427+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 11:06:15.427+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 11:06:15.427+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 11:06:15.427+0200 W/W_HOME  (  840): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
06-25 11:06:15.432+0200 W/W_INDICATOR(  756): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
06-25 11:06:15.432+0200 W/W_INDICATOR(  756): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-25 11:06:15.452+0200 I/APP_CORE(17812): appcore-efl.c: __do_app(453) > [APP 17812] Event: RESET State: CREATED
06-25 11:06:15.452+0200 I/CAPI_APPFW_APPLICATION(17812): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
06-25 11:06:15.467+0200 I/APP_CORE(17812): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
06-25 11:06:15.467+0200 I/APP_CORE(17812): appcore-efl.c: __do_app(524) > [APP 17812] Initial Launching, call the resume_cb
06-25 11:06:15.467+0200 I/CAPI_APPFW_APPLICATION(17812): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
06-25 11:06:15.477+0200 W/APP_CORE(17812): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:8a00002
06-25 11:06:15.487+0200 W/W_HOME  (  840): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
06-25 11:06:15.487+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: _rotary_selector_move_cb(776) > called!!
06-25 11:06:15.487+0200 I/efl-extension(17812): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(649) > surface 0x417f14b8 = w: 1 h: 1  obj 0x417fbc70 w: 360 h: 360
06-25 11:06:15.487+0200 I/efl-extension(17812): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(673) > Surface will be initialized! surface->w= 360 surface->h = 360
06-25 11:06:15.492+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: _item_update_animator_cb(1414) > called
06-25 11:06:15.492+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: _item_update_animator_cb(1423) > item_list(0x1099447280), count(7)
06-25 11:06:15.707+0200 W/W_HOME  (  840): event_manager.c: _window_visibility_cb(466) > Window [0x2E00003] is now visible(1)
06-25 11:06:15.707+0200 W/W_HOME  (  840): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
06-25 11:06:15.707+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 11:06:15.707+0200 W/W_HOME  (  840): event_manager.c: _state_control(326) > appcore paused manually
06-25 11:06:15.707+0200 W/W_HOME  (  840): main.c: home_appcore_pause(514) > Home Appcore Paused
06-25 11:06:15.707+0200 W/W_HOME  (  840): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
06-25 11:06:15.707+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 11:06:15.707+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 11:06:15.707+0200 W/W_HOME  (  840): main.c: home_pause(546) > clock/widget paused
06-25 11:06:15.707+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 11:06:15.707+0200 W/W_INDICATOR(  756): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
06-25 11:06:15.707+0200 W/W_INDICATOR(  756): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-25 11:06:15.712+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-25 11:06:15.712+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-25 11:06:15.712+0200 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-25 11:06:15.712+0200 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-25 11:06:15.712+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-25 11:06:15.712+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-25 11:06:15.712+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-25 11:06:15.712+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-25 11:06:15.712+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-25 11:06:15.712+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-25 11:06:15.712+0200 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-25 11:06:15.712+0200 I/MESSAGE_PORT(  481): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-25 11:06:15.712+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-25 11:06:15.712+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-25 11:06:15.712+0200 I/MESSAGE_PORT(  481): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-25 11:06:15.712+0200 I/MESSAGE_PORT(  481): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-25 11:06:15.712+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-25 11:06:15.712+0200 I/MESSAGE_PORT(  481): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-25 11:06:15.712+0200 W/W_HOME  (  840): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 11:06:15.712+0200 E/CAPI_APPFW_APP_CONTROL( 1257): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-25 11:06:15.712+0200 W/MUSIC_CONTROL_SERVICE( 1257): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1257]   [com.samsung.w-home]register msg port [false][0m
06-25 11:06:15.712+0200 E/W_HOME  (  840): win.c: win_rotation_disable_set(186) > failed to get key VCONFKEY_DISABLE_ROTATION
06-25 11:06:15.712+0200 W/W_HOME  (  840): main.c: _window_visibility_cb(963) > Window [0x2E00003] is now visible(1)
06-25 11:06:15.712+0200 I/APP_CORE(  840): appcore-efl.c: __do_app(453) > [APP 840] Event: PAUSE State: RUNNING
06-25 11:06:15.712+0200 I/CAPI_APPFW_APPLICATION(  840): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-25 11:06:15.712+0200 W/W_HOME  (  840): main.c: _appcore_pause_cb(487) > appcore pause
06-25 11:06:15.712+0200 E/W_HOME  (  840): main.c: _pause_cb(465) > paused already
06-25 11:06:15.712+0200 I/wnotib  (  840): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
06-25 11:06:15.712+0200 E/wnotib  (  840): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
06-25 11:06:15.712+0200 W/wnotib  (  840): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [41], notiboard card appending count [80].
06-25 11:06:15.722+0200 W/AUL     (  506): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(840) status(bg) type(uiapp)
06-25 11:06:15.722+0200 W/STARTER (  755): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[840] goes to (4)
06-25 11:06:15.722+0200 E/STARTER (  755): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 840)'s state(4)
06-25 11:06:15.722+0200 W/AUL_AMD (  506): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-25 11:06:15.722+0200 W/AUL_AMD (  506): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
06-25 11:06:15.722+0200 W/AUL     (  506): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.scorekeeperforgear) pid(17812) status(fg) type(uiapp)
06-25 11:06:15.722+0200 W/STARTER (  755): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[17812] goes to (3)
06-25 11:06:15.752+0200 E/APP_SHORTCUT_WIDGET(  993): main.c: widget_instance_pause(1669) >  (!popup) -> widget_instance_pause() return
06-25 11:06:15.752+0200 I/CAPI_WIDGET_APPLICATION(  993): widget_app.c: __provider_pause_cb(298) > widget obj was paused
06-25 11:06:15.752+0200 W/AUL     (  993): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.app-widget.widget) pid(993) status(bg) type(widgetapp)
06-25 11:06:15.752+0200 I/CAPI_WIDGET_APPLICATION(  993): widget_app.c: __check_status_for_cgroup(145) > enter background group
06-25 11:06:15.827+0200 E/TBM     (  461): tbm_bufmgr.c: _tgl_destroy(141) > [libtbm:461] error(Device or resource busy) _tgl_destroy:141 key:64
06-25 11:06:15.842+0200 I/APP_CORE(17812): appcore-efl.c: __do_app(453) > [APP 17812] Event: RESUME State: RUNNING
06-25 11:06:15.987+0200 E/EFL     (17812): ecore_x<17812> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=16668177 button=1
06-25 11:06:15.992+0200 E/ALARM_MANAGER(  512): alarm-manager.c: __alarm_handler_idle(1484) > Lock the display not to enter LCD OFF
06-25 11:06:16.002+0200 E/ALARM_MANAGER(  512): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
06-25 11:06:16.012+0200 W/AUL     (  512): app_signal.c: aul_update_freezer_status(456) > aul_update_freezer_status pid(499) type(wakeup)
06-25 11:06:16.017+0200 E/RESOURCED(  598): freezer-process.c: freezer_process_pid_set(150) > Cant find process info for 499
06-25 11:06:16.017+0200 E/ALARM_MANAGER(  499): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.aweconn] : Alarm id [731054387]
06-25 11:06:16.017+0200 W/WECONN  (  499): <__wc_device_try_to_connect_on_wear:171> { state=WC_FEATURE_STATE_ON, vendor=WC_DEVICE_OS_TYPE_ANDROID
06-25 11:06:16.017+0200 W/WECONN  (  499): <wc_manager_get_bearer_state:988> type : 1
06-25 11:06:16.017+0200 W/WECONN  (  499): <__wc_device_try_to_connect:677> connection=WC_CONNECTION_TYPE_BLUETOOTH_SPP_AUTOSWITCH, bearer=WC_BEARER_TYPE_BLUETOOTH
06-25 11:06:16.017+0200 W/WECONN  (  499): <__connect_for_auto_switch:1706> { device=0x42901a58, device->bt_address=B4:48
06-25 11:06:16.037+0200 E/ALARM_MANAGER(  512): alarm-manager.c: __alarm_expired(1445) > alarm_id[731054387] is expired.
06-25 11:06:16.037+0200 E/ALARM_MANAGER(  512): alarm-manager.c: __save_module_log(1778) > The file is not ready.
06-25 11:06:16.037+0200 E/ALARM_MANAGER(  512): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(731054387)
06-25 11:06:16.037+0200 E/ALARM_MANAGER(  512): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(161312982) is OVER.
06-25 11:06:16.037+0200 E/ALARM_MANAGER(  512): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
06-25 11:06:16.037+0200 E/ALARM_MANAGER(  512): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 25-6-2017, 09:11:07 (UTC).
06-25 11:06:16.037+0200 E/ALARM_MANAGER(  512): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
06-25 11:06:16.037+0200 E/ALARM_MANAGER(  512): alarm-manager.c: __save_module_log(1778) > The file is not ready.
06-25 11:06:16.037+0200 E/ALARM_MANAGER(  512): alarm-manager.c: __alarm_handler_idle(1510) > Unlock the display from LCD OFF
06-25 11:06:16.057+0200 E/ALARM_MANAGER(  512): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
06-25 11:06:16.082+0200 E/AUL     (  506): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
06-25 11:06:16.132+0200 W/WECONN  (  499): <__connect_for_auto_switch:1719> }
06-25 11:06:16.132+0200 W/WECONN  (  499):  ### Connect Request [WC_CONNECTION_TYPE_BLUETOOTH_SPP_AUTOSWITCH]
06-25 11:06:16.132+0200 W/WECONN  (  499): <__wc_device_try_to_connect_on_wear:185> }
06-25 11:06:16.212+0200 I/APP_CORE(  840): appcore-efl.c: __do_app(453) > [APP 840] Event: MEM_FLUSH State: PAUSED
06-25 11:06:16.212+0200 W/WRT_PLUGINS/TIZEN(17384): SystemInfoCpu.cpp: fetchLoad(76) > Cannot calculate cpu load, previous value returned
06-25 11:06:16.232+0200 E/EFL     (17812): ecore_x<17812> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=16668318 button=1
06-25 11:06:16.232+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_selected_item_get(2961) > called!!
06-25 11:06:16.232+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_get(2370) > called!!
06-25 11:06:16.232+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_get(2370) > called!!
06-25 11:06:16.377+0200 W/AUL_AMD (  506): amd_request.c: __request_handler(669) > __request_handler: 14
06-25 11:06:16.387+0200 W/AUL_AMD (  506): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17812
06-25 11:06:16.387+0200 W/AUL_AMD (  506): amd_request.c: __request_handler(669) > __request_handler: 12
06-25 11:06:16.407+0200 W/AUL_AMD (  506): amd_request.c: __request_handler(669) > __request_handler: 14
06-25 11:06:16.412+0200 W/AUL_AMD (  506): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17812
06-25 11:06:16.412+0200 W/AUL_AMD (  506): amd_request.c: __request_handler(669) > __request_handler: 12
06-25 11:06:16.422+0200 E/EFL     (17812): elementary<17812> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
06-25 11:06:16.432+0200 E/EFL     (17812): elementary<17812> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x4457a3e0) will be pushed
06-25 11:06:16.482+0200 I/efl-extension(17812): efl_extension_more_option.c: eext_more_option_add(323) > called!!
06-25 11:06:16.487+0200 I/efl-extension(17812): efl_extension_more_option.c: _drawer_layout_create(183) > called!!
06-25 11:06:16.487+0200 I/efl-extension(17812): efl_extension_more_option.c: _more_option_data_init(246) > mold is initialized!!
06-25 11:06:16.487+0200 I/efl-extension(17812): efl_extension_more_option.c: _panel_create(202) > called!!
06-25 11:06:16.497+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_add(1990) > called!!
06-25 11:06:16.507+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: _eext_rotary_selector_data_init(586) > rsd is initialized!!
06-25 11:06:16.507+0200 I/efl-extension(17812): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
06-25 11:06:16.507+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: _event_area_callback_add(500) > called!!
06-25 11:06:16.517+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: _rotary_selector_show_cb(805) > called!!
06-25 11:06:16.517+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: _items_invalidate(919) > item_count is zero!!
06-25 11:06:16.522+0200 I/efl-extension(17812): efl_extension_more_option.c: eext_more_option_direction_set(414) > called!!
06-25 11:06:16.537+0200 E/EFL     (17812): edje<17812> edje_util.c:3785 edje_object_size_min_restricted_calc() group elm/panel/bottom/default has a non-fixed part 'cue.event'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-25 11:06:16.537+0200 E/EFL     (17812): edje<17812> edje_util.c:3785 edje_object_size_min_restricted_calc() group elm/panel/bottom/default has a non-fixed part 'cue.event'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-25 11:06:16.537+0200 I/efl-extension(17812): efl_extension_more_option.c: eext_more_option_item_append(456) > called!!
06-25 11:06:16.537+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 11:06:16.547+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 11:06:16.547+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 11:06:16.552+0200 I/efl-extension(17812): efl_extension_more_option.c: eext_more_option_item_append(456) > called!!
06-25 11:06:16.552+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 11:06:16.557+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 11:06:16.557+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 11:06:16.557+0200 I/efl-extension(17812): efl_extension_more_option.c: eext_more_option_item_append(456) > called!!
06-25 11:06:16.557+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 11:06:16.562+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 11:06:16.562+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 11:06:16.562+0200 I/efl-extension(17812): efl_extension_more_option.c: eext_more_option_item_append(456) > called!!
06-25 11:06:16.562+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 11:06:16.567+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 11:06:16.567+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 11:06:16.812+0200 I/AUL_PAD (17887): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
06-25 11:06:16.842+0200 E/EFL     (17812): elementary<17812> elc_naviframe.c:2796 _push_transition_cb() item(0x4457a3e0) will transition
06-25 11:06:16.847+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: _item_update_animator_cb(1414) > called
06-25 11:06:16.847+0200 I/efl-extension(17812): efl_extension_rotary_selector.c: _item_update_animator_cb(1423) > item_list(0x1175022536), count(4)
06-25 11:06:16.862+0200 E/EFL     (17812): edje<17812> edje_util.c:3785 edje_object_size_min_restricted_calc() group elm/panel/bottom/default has a non-fixed part 'cue.event'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-25 11:06:17.077+0200 E/EFL     (  461): ecore_x<461> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x8a00002 time=16669122
06-25 11:06:17.212+0200 W/WRT_PLUGINS/TIZEN(17384): SystemInfoCpu.cpp: fetchLoad(76) > Cannot calculate cpu load, previous value returned
06-25 11:06:17.467+0200 W/AUL_PAD ( 1356): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 17812 pgid = 17812
06-25 11:06:17.467+0200 W/AUL_PAD ( 1356): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
06-25 11:06:17.467+0200 W/CRASH_MANAGER(17903): worker.c: worker_job(1205) > 111781273636f149838157
