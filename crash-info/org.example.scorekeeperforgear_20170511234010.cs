S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.2
Build-Number: R732XXU2EQC1
Build-Date: 2017.03.13 20:32:41

Crash Information
Process Name: scorekeeperforgear
PID: 14310
Date: 2017-05-11 23:40:10+0200
Executable File Path: /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 14310, uid 5000)

Register Information
r0   = 0x6f746b73, r1   = 0x00000004
r2   = 0x413c1dd1, r3   = 0x45e610f8
r4   = 0x6f746b73, r5   = 0x00000000
r6   = 0x413c1dd1, r7   = 0x413c1dd1
r8   = 0x00000001, r9   = 0x45e610f8
r10  = 0x45e610f0, fp   = 0x45e610d0
ip   = 0x413d33e4, sp   = 0xbe9871c8
lr   = 0x413c1a6d, pc   = 0x416de442
cpsr = 0x20000030

Memory Information
MemTotal:   491132 KB
MemFree:     31148 KB
Buffers:      3992 KB
Cached:      72052 KB
VmPeak:     105836 KB
VmSize:      95904 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       31320 KB
VmRSS:       21956 KB
VmData:      33528 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25420 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 14310 TID = 14310
14310 14403 

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
413be000 413c3000 r-xp /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
413d4000 413d8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
413e1000 413e3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
413ec000 413f2000 r-xp /usr/lib/libappsvc.so.0.1.0
413fa000 4141e000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41427000 414f6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4150c000 41516000 r-xp /lib/libnss_files-2.13.so
416b2000 416bd000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
416c8000 416cd000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
416d5000 416e1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
416ea000 4170b000 r-xp /usr/lib/libefl-extension.so.0.1.0
41713000 41718000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41720000 4174a000 r-xp /usr/lib/libsensor.so.1.9.5
41753000 4175a000 r-xp /usr/lib/libctx-shared.so.0.8.3
41762000 41767000 r-xp /usr/lib/libctx-client.so.0.8.3
4176f000 41781000 r-xp /usr/lib/libefl-assist.so.0.1.0
41789000 41841000 r-xp /usr/lib/libcairo.so.2.11200.14
4184c000 41856000 r-xp /usr/lib/libsensord-shared.so
4185e000 4186d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
41876000 4188c000 r-xp /usr/lib/libtts.so
41895000 418b8000 r-xp /usr/lib/libui-extension.so.0.1.0
418c1000 418cc000 r-xp /usr/lib/libtbm.so.1.0.0
418d4000 418e2000 r-xp /usr/lib/libGLESv2.so.2.0
418eb000 418ec000 r-xp /usr/lib/libxcb-shm.so.0.0.0
418f5000 418fb000 r-xp /usr/lib/libxcb-render.so.0.0.0
41903000 41906000 r-xp /usr/lib/libEGL.so.1.4
4190e000 41911000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41919000 4191a000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41923000 41a29000 r-xp /usr/lib/libicuuc.so.57.1
41a3f000 41a47000 r-xp /usr/lib/libdrm.so.2.4.0
41a4f000 41a51000 r-xp /usr/lib/libdri2.so.0.0.0
41a59000 41a5f000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41a67000 41a6c000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41a74000 41a76000 r-xp /usr/lib/libttrace.so.1.1
41a7e000 41a83000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
41a8e000 41a91000 rw-p [heap]
41a91000 41bc5000 rw-p [heap]
41bc5000 41d4d000 r-xp /usr/lib/libicui18n.so.57.1
41d5d000 41d76000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
43617000 43638000 r-xp /usr/lib/libexif.so.12.3.3
4364b000 43651000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4365a000 43662000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4366a000 4368c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43695000 4369c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
436a5000 436a7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
436af000 436b6000 r-xp /usr/lib/libminizip.so.1.0.0
436be000 436cb000 r-xp /usr/lib/libail.so.0.1.0
436d4000 436da000 r-xp /usr/lib/libproc-stat.so.0.2.96
436e2000 436e3000 r-xp /usr/lib/libresponse.so.0.2.96
436eb000 436f0000 r-xp /usr/lib/libsystem.so.0.0.0
436fa000 437c4000 r-xp /usr/lib/libCOREGL.so.4.0
43bf5000 43c00000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c09000 43c0e000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43c16000 43c2d000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43c3a000 43c3c000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
44444000 44445000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
44e09000 45687000 rw-p [stack:14403]
45687000 45688000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
456a6000 456ae000 r-xp /usr/lib/libfeedback.so.0.1.4
456b0000 456b1000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
456b9000 456bb000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
456c3000 456ce000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
456d6000 456dd000 r-xp /usr/lib/libmmfcommon.so.0.0.0
456e5000 456e9000 r-xp /usr/lib/libmmfsession.so.0.0.0
456f2000 456f6000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45800000 45818000 r-xp /usr/lib/libmmfsound.so.0.1.0
45829000 45834000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45841000 45857000 r-xp /usr/lib/libavsysaudio.so.0.0.1
4585f000 458c0000 r-xp /usr/lib/libasound.so.2.0.0
458ca000 458cd000 r-xp /usr/lib/libpulse-simple.so.0.0.4
458d5000 4590d000 r-xp /usr/lib/libpulse.so.0.16.2
4590e000 45911000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
45919000 45961000 r-xp /usr/lib/libmdm.so.1.2.62
45962000 45965000 r-xp /usr/lib/libtinycompress.so.0.0.0
4596d000 45972000 r-xp /usr/lib/libjson.so.0.0.1
4597a000 459c3000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
459cc000 45a13000 r-xp /usr/lib/libsndfile.so.1.0.26
45a1f000 45a2e000 r-xp /usr/lib/libmdm-common.so.1.1.22
45a37000 45a59000 r-xp /usr/lib/libvorbis.so.0.4.3
45a61000 45a65000 r-xp /usr/lib/libogg.so.0.7.1
be967000 be988000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14310)
Call Stack Count: 19
 0: sensor_listener_set_event_cb + 0x15 (0x416de442) [/usr/lib/libcapi-system-sensor.so.0] + 0x9442
 1: SensorProcess::SensorProcess(int) + 0xd8 (0x413c1a6d) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x3a6d
 2: _item_clicked_cb(void*, _Evas_Object*, void*) + 0x56 (0x413c0527) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x2527
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
14: ui_app_main + 0xb0 (0x41392421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
15: main + 0xb6 (0x413c021b) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x221b
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
35muwServiceHandle:7, uwChannelId:999, uwPayloadLength: 1585[0;m
05-11 23:40:09.110+0200 W/SHealthCommon(22892): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 0[0;m
05-11 23:40:09.110+0200 W/SHealthService(22892): SAPMessageDispatcher.cpp: GetHostMessageInfo(274) > [1;40;33mobject format[0;m
05-11 23:40:09.110+0200 W/SHealthCommon(22892): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (responseMessage)[0;m
05-11 23:40:09.110+0200 W/SHealthCommon(22892): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (message)[0;m
05-11 23:40:09.110+0200 W/SHealthCommon(22892): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_type)[0;m
05-11 23:40:09.110+0200 W/SHealthCommon(22892): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_feature)[0;m
05-11 23:40:09.110+0200 W/SHealthService(22892): SAPMessageDispatcher.cpp: Dispatch(173) > [1;40;33mSHealth Capability message[0;m
05-11 23:40:09.110+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(22892): preference.c: _preference_check_retry_err(507) > key(debug_wearable_message), check retry err: -21/(2/No such file or directory).
05-11 23:40:09.110+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(22892): preference.c: _preference_get_key(1101) > _preference_get_key(debug_wearable_message) step(-17825744) failed(2 / No such file or directory)
05-11 23:40:09.110+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(22892): preference.c: preference_get_boolean(1173) > preference_get_boolean(22892) : debug_wearable_message error
05-11 23:40:09.115+0200 W/SHealthCommon(22892): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
05-11 23:40:09.115+0200 W/SHealthService(22892): SAPCapabilityManager.cpp: OnSAPCapabilityMessageReceived(1428) > [1;40;33mHost SHealth version : 5710029,000000[0;m
05-11 23:40:09.115+0200 W/SHealthCommon(22892): PreferenceManager.cpp: SetMobileSHealthVersion(1021) > [1;35mMobileSHealthVersion: 0,000000[0;m
05-11 23:40:09.120+0200 W/SHealthCommon(22892): PreferenceManager.cpp: SetMobileSHealthVersion(1021) > [1;35mMobileSHealthVersion: 5710029,000000[0;m
05-11 23:40:09.125+0200 W/SHealthCommon(22892): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
05-11 23:40:09.135+0200 W/SHealthCommon(22892): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
05-11 23:40:09.135+0200 W/SHealthService(22892): SAPCapabilityManager.cpp: CastHostTrackerFeatureCapabilityUpdatedEvent(1376) > [1;35mCastHostTrackerFeatureCapabilityUpdatedEvent[0;m
05-11 23:40:09.140+0200 W/SHealthService(22892): WaterCaffeineController.cpp: OnHostTrackerFeatureCapabilityUpdated(130) > [1;35misHostSupportWaterMinus: 1, isHostSupportCaffeineMinus: 1, isHostSupportWaterAmount : 1, isHostSupportCaffeineAmount : 1[0;m
05-11 23:40:09.155+0200 W/SHealthService(22892): DirectShareController.cpp: OnHostTrackerFeatureCapabilityUpdated(260) > [1;40;33m[tracker_type] is not available in capability. Set default SPORT:[1,2,3] only.[0;m
05-11 23:40:09.155+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(22892): preference.c: _preference_check_retry_err(507) > key(together_prod_list_support), check retry err: -21/(2/No such file or directory).
05-11 23:40:09.155+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(22892): preference.c: _preference_get_key(1101) > _preference_get_key(together_prod_list_support) step(-17825744) failed(2 / No such file or directory)
05-11 23:40:09.155+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(22892): preference.c: preference_get_boolean(1173) > preference_get_boolean(22892) : together_prod_list_support error
05-11 23:40:09.170+0200 W/SHealthCommon(22892): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
05-11 23:40:09.170+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(22892): preference.c: _preference_check_retry_err(507) > key(host_together_supported), check retry err: -21/(2/No such file or directory).
05-11 23:40:09.170+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(22892): preference.c: _preference_get_key(1101) > _preference_get_key(host_together_supported) step(-17825744) failed(2 / No such file or directory)
05-11 23:40:09.170+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(22892): preference.c: preference_get_boolean(1173) > preference_get_boolean(22892) : host_together_supported error
05-11 23:40:09.180+0200 W/SHealthCommon(22892): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
05-11 23:40:09.180+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(22892): preference.c: _preference_check_retry_err(507) > key(host_together_supported), check retry err: -21/(2/No such file or directory).
05-11 23:40:09.180+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(22892): preference.c: _preference_get_key(1101) > _preference_get_key(host_together_supported) step(-17825744) failed(2 / No such file or directory)
05-11 23:40:09.180+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(22892): preference.c: preference_get_boolean(1173) > preference_get_boolean(22892) : host_together_supported error
05-11 23:40:09.180+0200 W/SHealthService(22892): SocialController.cpp: OnHostTrackerFeatureCapabilityUpdated(686) > [1;40;33mmNegotiatedFeatureCapabilityVersion[1010], hostChallengeNudgeListSupport[0], hostServerSyncTriggerSupport[1][0;m
05-11 23:40:09.180+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(22892): preference.c: _preference_check_retry_err(507) > key(disclaimer), check retry err: -21/(2/No such file or directory).
05-11 23:40:09.180+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(22892): preference.c: _preference_get_key(1101) > _preference_get_key(disclaimer) step(-17825744) failed(2 / No such file or directory)
05-11 23:40:09.180+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(22892): preference.c: preference_get_boolean(1173) > preference_get_boolean(22892) : disclaimer error
05-11 23:40:09.195+0200 W/SHealthCommon(22892): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
05-11 23:40:09.200+0200 W/SHealthService(22892): SAP.cpp: SAPClientSend(423) > [1;40;33msend before message length [382][0;m
05-11 23:40:09.210+0200 I/efl-extension(14310): efl_extension_rotary_selector.c: _selector_animation_finished_cb(1795) > called!!
05-11 23:40:09.210+0200 I/WSM     ( 1149): WSM_I [Run, line = 118, thread  = 413d5460] Read request from client. 
05-11 23:40:09.215+0200 I/WSM     ( 1149): WSM_I [Run] Request len 406c 
05-11 23:40:09.215+0200 I/WSM     ( 1149): WSM_D [Run] Request data  =  [len=16492] 0004a04370030000a0ea58547b20226d65737361676522203a202252455155455354222c202273656e64657222203a2022636f6d2e73616d73756e672e74697a656e676561722e6170702e736865616c74682e736f6369616c222c2022726563656976657222203a2022636f6d2e73616d73756e672e6d6f62696c652e6170702e736865616c74682e736f6369616c222c202276657273696f6e22203a20352e303039393939393939393939393939382c202264657669636522203a20223130303332222c202273657175656e63655f6e756d22203a203133302c20227479706522203a20224d455353414745222c2022626f647922203a2022483473494141414141414141413674575543704c4c53724f7a4d3954557242534d4451774e4e42525545724c4c30704f6a53387453456b735351554a5679736f4a536158514e556f75666b484f627647687761344f49613478676535426f6136426f636f4158575656426141565373427453556d4a5259444f62554b74514330576a41475951414141413d3d22207d0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
05-11 23:40:09.215+0200 W/SHealthService(22892): SAP.cpp: SAPClientSend(440) > [1;40;33msend data success !! message length = [382][0;m
05-11 23:40:09.215+0200 W/SHealthService(22892): SHealthServiceProxy.cpp: OnHostSendSuccess(148) > [1;35mmessage is sent successfully[0;m
05-11 23:40:09.215+0200 W/SHealthService(22892): SAPMessageDispatcher.cpp: OnHostMessageProgress(464) > [1;35msync progress [0][0;m
05-11 23:40:09.230+0200 W/SHealthService(22892): CommonSyncStorage.cpp: RecoverCommonSyncDuration(244) > [1;35mUpdated all 'shealth_common_sync_duration' start_time to 1491861600000,000000[0;m
05-11 23:40:09.230+0200 I/WSM     ( 1149): WSM_I [Run, line = 150] Send reply to client.
05-11 23:40:09.230+0200 I/WSM     ( 1149): WSM_D [Run] Send reply =  [len=16492] 010000007003000006e275267b20226d65737361676522203a202252455155455354222c202273656e64657222203a2022636f6d2e73616d73756e672e74697a656e676561722e6170702e736865616c74682e736f6369616c222c2022726563656976657222203a2022636f6d2e73616d73756e672e6d6f62696c652e6170702e736865616c74682e736f6369616c222c202276657273696f6e22203a20352e303039393939393939393939393939382c202264657669636522203a20223130303332222c202273657175656e63655f6e756d22203a203133302c20227479706522203a20224d455353414745222c2022626f647922203a2022483473494141414141414141413674575543704c4c53724f7a4d3954557242534d4451774e4e42525545724c4c30704f6a53387453456b735351554a5679736f4a536158514e556f75666b484f627647687761344f49613478676535426f6136426f636f4158575656426141565373427453556d4a5259444f62554b74514330576a41475951414141413d3d22207d0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
05-11 23:40:09.230+0200 W/SHealthService(22892): CommonSyncStorage.cpp: RecoverCommonSyncDurationThatHasEndtimeBiggerThanCurrentTime(298) > [1;35mUpdated all 'shealth_common_sync_duration' end_time to 1494538809235,000000[0;m
05-11 23:40:09.230+0200 W/SHealthService(22892): CommonSyncStorage.cpp: RemoveCommonSyncDurationThatHasStartTimeBiggerThanEndTime(328) > [1;35mRemoved all where start_time is bigger than end_time[0;m
05-11 23:40:09.230+0200 W/SHealthService(22892): CommonSyncStorage.cpp: RecoverCommonSyncDurationForSyncTimeException(273) > [1;35mUpdated syncTimeException true records endtime to [1491861600000,000000][0;m
05-11 23:40:09.230+0200 W/SHealthService(22892): CommonSyncController.cpp: CommonSyncStart(175) > [1;35mRequest cpu lock[0;m
05-11 23:40:09.235+0200 W/SHealthService(22892): CpuLock.cpp: CheckAndReset(125) > [1;40;33mREQUEST POWER LOCK CPU [180000][0;m
05-11 23:40:09.255+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(22892): preference.c: _preference_check_retry_err(507) > key(maximum_long_term_sync_score), check retry err: -21/(2/No such file or directory).
05-11 23:40:09.255+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(22892): preference.c: _preference_get_key(1101) > _preference_get_key(maximum_long_term_sync_score) step(-17825744) failed(2 / No such file or directory)
05-11 23:40:09.255+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(22892): preference.c: preference_get_double(1214) > preference_get_double(22892) : maximum_long_term_sync_score error
05-11 23:40:09.255+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(22892): preference.c: _preference_check_retry_err(507) > key(chunk_per_hour), check retry err: -21/(2/No such file or directory).
05-11 23:40:09.255+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(22892): preference.c: _preference_get_key(1101) > _preference_get_key(chunk_per_hour) step(-17825744) failed(2 / No such file or directory)
05-11 23:40:09.255+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(22892): preference.c: preference_get_int(1132) > preference_get_int(22892) : key(chunk_per_hour) error
05-11 23:40:09.255+0200 W/SHealthService(22892): CommonSyncMakingTableInfo.cpp: GetStartOfTImeByScoreV45(212) > [1;40;33mstartTime[1494538167455,000000], endTime[1494538809221,000000], maxiumScore[3145728], chunkPerHour[1][0;m
05-11 23:40:09.260+0200 W/SHealthService(22892): CommonSyncMakingTableInfo.cpp: GetStartOfTImeByScoreV45(223) > [1;40;33mestimateStartTime[1494536400000,000000], scoreStartTime[1494538167455,000000], scoreEndTime[1494538809221,000000], score[1890,000000][0;m
05-11 23:40:09.260+0200 W/SHealthService(22892): CpuLock.cpp: CheckAndReset(128) > [1;40;33mRELEASE POWER LOCK CPU[0;m
05-11 23:40:09.275+0200 W/SHealthService(22892): CommonSyncController.cpp: CommonSyncStart(228) > [1;35mRelease cpu lock[0;m
05-11 23:40:09.275+0200 W/SHealthService(22892): CommonSyncController.cpp: CommonSyncStart(234) > [1;35mRequest cpu lock[0;m
05-11 23:40:09.275+0200 W/SHealthService(22892): CpuLock.cpp: CheckAndReset(125) > [1;40;33mREQUEST POWER LOCK CPU [180000][0;m
05-11 23:40:09.290+0200 W/SHealthService(22892): SAPV45MessageBuilder.cpp: MakeCommonSyncRequestMsg(169) > [1;40;33mstarTime: 1494538167455,000000, endTime: 1494538809221,000000, isLastChunk: 1, isMobileSHealthReset&sendMobileData: 1[0;m
05-11 23:40:09.305+0200 W/SHealthCommon(22892): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
05-11 23:40:09.310+0200 W/SHealthCommon(22892): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
05-11 23:40:09.315+0200 W/SHealthService(22892): SAPV45MessageBuilder.cpp: MakeUserProfileJsonArray(665) > [1;35mdon't send profile item / createTime [1471603931892,000000] / updateTime [0,000000] / uuid [00000000-0000-0000-0000-000000000014][0;m
05-11 23:40:09.315+0200 W/SHealthService(22892): SAPV45MessageBuilder.cpp: MakeHeartRateJsonArray(755) > [1;40;33mHeartRate is empty[0;m
05-11 23:40:09.320+0200 W/SHealthService(22892): SAPV45MessageBuilder.cpp: MakePedoStepCountJsonArray(833) > [1;40;33mpedo step is empty[0;m
05-11 23:40:09.320+0200 W/SHealthService(22892): SAPV45MessageBuilder.cpp: MakePedoEventJsonArray(885) > [1;40;33mpedo event is empty[0;m
05-11 23:40:09.330+0200 W/SHealthService(22892): SAPV45MessageBuilder.cpp: MakeCommonSyncRequestMsg(325) > [1;40;33mGEAR_SYNC_MSG [ action : SYNC_DATA ][ device : Gear S2, device_type : 10032, version : 4.510000, start_time : 1494538167455, end_time : 1494538809221, last_sync_time : 1494538168016, is_last_chunk : 1, reset_time : 1487887200000 ] [size: 2344][0;m
05-11 23:40:09.340+0200 W/SHealthCommon(22892): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
05-11 23:40:09.340+0200 W/SHealthService(22892): SAP.cpp: SAPClientSend(423) > [1;40;33msend before message length [1060][0;m
05-11 23:40:09.350+0200 W/SHealthService(22892): SAP.cpp: SAPClientSend(440) > [1;40;33msend data success !! message length = [1060][0;m
05-11 23:40:09.350+0200 W/SHealthService(22892): SHealthServiceProxy.cpp: OnHostSendSuccess(148) > [1;35mmessage is sent successfully[0;m
05-11 23:40:09.350+0200 W/SHealthService(22892): SAPMessageDispatcher.cpp: OnHostMessageProgress(464) > [1;35msync progress [0][0;m
05-11 23:40:09.350+0200 W/SHealthService(22892): CpuLock.cpp: CheckAndReset(128) > [1;40;33mRELEASE POWER LOCK CPU[0;m
05-11 23:40:09.350+0200 I/WSM     ( 1149): WSM_I [Run, line = 118, thread  = 413d5460] Read request from client. 
05-11 23:40:09.350+0200 I/WSM     ( 1149): WSM_I [Run] Request len 406c 
05-11 23:40:09.350+0200 I/WSM     ( 1149): WSM_D [Run] Request data  =  [len=16492] 0004a04370030000a0ea585478da8d934bcfaa481884ffca17b74c046c1098e42c00b988a08288c866c2a5815669109aeb64fefbf89d934966318ba96555bd4f6af3fef9b5aa60d7c5055c7dfdfeb5f234f7aa5dfcd56f5fab0ee20cb63fddb4aed65d5c753d2ed6042d1017306ed771d3acbb12c62f52aec78f11272fb8ee669c5631fef0da6f480b538886ffc0c4386b6b94fd2fc8e7be4335fe66f06b8691fe2df193677040e9affd2cc380cdaff5ef1ee214fe81fbea3b6101fb71c9dcfceaed645ffeae257536ff344caedbcbff88df046043258eb233e929d4d209467889a4f7d234be446c69b1023db71d2d9e6537892ce30924b0c9fc9bf6da6179a43da7cd2491cbb1489b1d9d9be2445c547125bfb5ba1cd2100a91313fbca1cc417ba6c1568c4a3acf1f3c679201d403c8aa5c52e0c85393bf242541436104e075ae01cdfadbca01bd7cd06aa2dea57917f4da49bc04f226147dee1547179eaf81c0ea938e524f0df6a9c5e1a94005458d8fc3f890c7a1a9df38ee1ff753ee29f2adb9866ab09bad9b74b3b012b49bfb69bce8ce022cab704df52044cf0c27c9d123ba216d0cee5ddbb7fed8326a15c2d90e9f4793ba15d570976c2e566b53976e7911e94212dccb435d96d56e136d9f8edb8ca89e05816bfc8c6b264dbded3967bc656e6ede9374271a9b97
05-11 23:40:09.355+0200 I/WSM     ( 1149): WSM_I [Run, line = 150] Send reply to client.
05-11 23:40:09.355+0200 I/WSM     ( 1149): WSM_D [Run] Send reply =  [len=16492] 010000007003000006e2752678da8d934bcfaa481884ffca17b74c046c1098e42c00b988a08288c866c2a5815669109aeb64fefbf89d934966318ba96555bd4f6af3fef9b5aa60d7c5055c7dfdfeb5f234f7aa5dfcd56f5fab0ee20cb63fddb4aed65d5c753d2ed6042d1017306ed771d3acbb12c62f52aec78f11272fb8ee669c5631fef0da6f480b538886ffc0c4386b6b94fd2fc8e7be4335fe66f06b8691fe2df193677040e9affd2cc380cdaff5ef1ee214fe81fbea3b6101fb71c9dcfceaed645ffeae257536ff344caedbcbff88df046043258eb233e929d4d209467889a4f7d234be446c69b1023db71d2d9e6537892ce30924b0c9fc9bf6da6179a43da7cd2491cbb1489b1d9d9be2445c547125bfb5ba1cd2100a91313fbca1cc417ba6c1568c4a3acf1f3c679201d403c8aa5c52e0c85393bf242541436104e075ae01cdfadbca01bd7cd06aa2dea57917f4da49bc04f226147dee1547179eaf81c0ea938e524f0df6a9c5e1a94005458d8fc3f890c7a1a9df38ee1ff753ee29f2adb9866ab09bad9b74b3b012b49bfb69bce8ce022cab704df52044cf0c27c9d123ba216d0cee5ddbb7fed8326a15c2d90e9f4793ba15d570976c2e566b53976e7911e94212dccb435d96d56e136d9f8edb8ca89e05816bfc8c6b264dbded3967bc656e6ede9374271a9b97c8f
05-11 23:40:09.360+0200 W/SHealthService(22892): CommonSyncController.cpp: CommonSyncStart(281) > [1;35mRelease cpu lock[0;m
05-11 23:40:09.665+0200 I/WSM     ( 1149): WSM_I [Run, line = 118, thread  = 413d5460] Read request from client. 
05-11 23:40:09.665+0200 I/WSM     ( 1149): WSM_I [Run] Request len 406c 
05-11 23:40:09.665+0200 I/WSM     ( 1149): WSM_D [Run] Request data  =  [len=16492] 0004a04380030000a0ea58546c98836c3a110c4c00aaaf66f1893c188fdb84be73940a30dc8e3a5933b7d854369b1e4218ba4c850554c9ea2cc53c0202a1fe449d20ae66ad6c7e486c645488c8e5376dbc6c202f7de0f4b627d8a7c7852cb7d3175bb497b36c6321074a7f2d517b29bfbb7aac6bef76e8d02473a2fd4993574dca0111fc8bf8175008d349473d0deee5958cce8062582baf18ab7cf203938a143f2bb072c266cc7bcc13418ef6eac58ce2588e146756cfd5bbb4a65c0794e640a5fae4bc669d7aabc45fff2f1c1fc6430c892145acd878043d8c1e35e3ce4ac78673fdc490330d61be07484b4da94196e10cd03e3dc1cb408a1b607694ea69bed3ebaba40867d11004e55db73f19e6e24ad7f4749a8f7aa855635fccb90b25b7a1c278ec8ef6173fc2e5f11c6a59dff7db5cd09a041a07f86d94c3ac16ec357dd24d8e5c695ed9d4bdebdac92c4de134a55dfeba394dc48c3c7772c439823b7b19b712577de57b43638c33e1fa77322ca41a771d09211f13383e92b5ac25bad683bea3814321c5fd1b6a6294cbc514a72a15b4059b3d1401b43d80735f21c440a31d0000006c9ba2cb26762dedc32a0222d0cb41271e7a77314cecb961d9aaee99c3b95793c6d732dd621fefc33c9d4956b88716475e7addd64baa359e82b260bef6c18aeb000000000000
05-11 23:40:09.665+0200 I/WSM     ( 1149): WSM_I [Run, line = 150] Send reply to client.
05-11 23:40:09.665+0200 I/WSM     ( 1149): WSM_D [Run] Send reply =  [len=16492] 010000008003000006e275266c98836c3a110c4c00aaaf66f1893c188fdb84be73940a30dc8e3a5933b7d854369b1e4218ba4c850554c9ea2cc53c0202a1fe449d20ae66ad6c7e486c645488c8e5376dbc6c202f7de0f4b627d8a7c7852cb7d3175bb497b36c6321074a7f2d517b29bfbb7aac6bef76e8d02473a2fd4993574dca0111fc8bf8175008d349473d0deee5958cce8062582baf18ab7cf203938a143f2bb072c266cc7bcc13418ef6eac58ce2588e146756cfd5bbb4a65c0794e640a5fae4bc669d7aabc45fff2f1c1fc6430c892145acd878043d8c1e35e3ce4ac78673fdc490330d61be07484b4da94196e10cd03e3dc1cb408a1b607694ea69bed3ebaba40867d11004e55db73f19e6e24ad7f4749a8f7aa855635fccb90b25b7a1c278ec8ef6173fc2e5f11c6a59dff7db5cd09a041a07f86d94c3ac16ec357dd24d8e5c695ed9d4bdebdac92c4de134a55dfeba394dc48c3c7772c439823b7b19b712577de57b43638c33e1fa77322ca41a771d09211f13383e92b5ac25bad683bea3814321c5fd1b6a6294cbc514a72a15b4059b3d1401b43d80735f21c440a31d0000006c9ba2cb26762dedc32a0222d0cb41271e7a77314cecb961d9aaee99c3b95793c6d732dd621fefc33c9d4956b88716475e7addd64baa359e82b260bef6c18aeb000000000000000
05-11 23:40:09.680+0200 W/SHealthService(22892): SAPNotificationCallback.cpp: SAPNotiOnDataIndication(49) > [1;35muwServiceHandle:7, uwChannelId:999, uwPayloadLength: 389[0;m
05-11 23:40:09.680+0200 W/SHealthCommon(22892): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 0[0;m
05-11 23:40:09.680+0200 W/SHealthService(22892): SAPMessageDispatcher.cpp: GetHostMessageInfo(274) > [1;40;33mobject format[0;m
05-11 23:40:09.685+0200 W/SHealthCommon(22892): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (responseMessage)[0;m
05-11 23:40:09.685+0200 W/SHealthCommon(22892): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (message_type)[0;m
05-11 23:40:09.685+0200 W/SHealthCommon(22892): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (capability_type)[0;m
05-11 23:40:09.685+0200 W/SHealthCommon(22892): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_type)[0;m
05-11 23:40:09.685+0200 W/SHealthCommon(22892): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_feature)[0;m
05-11 23:40:09.685+0200 W/SHealthService(22892): SAPMessageDispatcher.cpp: Dispatch(200) > [1;40;33mAPP COMMAND MESSAGE!![0;m
05-11 23:40:09.685+0200 W/SHealthService(22892): AppCmdManager.cpp: OnSAPAppCommand(391) > [1;35mAPP COMMAND MESSAGE RECEIVER: com.samsung.tizengear.app.shealth.social, BODY SIZE[176] [0;m
05-11 23:40:09.685+0200 W/SHealthCommon(22892): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 0[0;m
05-11 23:40:09.685+0200 W/SHealthService(22892): CpuLock.cpp: CheckAndReset(125) > [1;40;33mREQUEST POWER LOCK CPU [180000][0;m
05-11 23:40:09.695+0200 W/SHealthCommon(22892): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (update_time)[0;m
05-11 23:40:09.695+0200 W/SHealthService(22892): CpuLock.cpp: CheckAndReset(128) > [1;40;33mRELEASE POWER LOCK CPU[0;m
05-11 23:40:09.725+0200 I/WSM     ( 1149): WSM_I [Run, line = 118, thread  = 413d5460] Read request from client. 
05-11 23:40:09.725+0200 I/WSM     ( 1149): WSM_I [Run] Request len 406c 
05-11 23:40:09.725+0200 I/WSM     ( 1149): WSM_D [Run] Request data  =  [len=16492] 0004a04380030000a0ea5854d00deb5e9b174f8ac0b3bc74ff6c9ee9556b2a411ff3b1cc696c4ce9d1d27652e7bbd328d1246a6d83a58c28e2e62e2ccf5fb104c42daa423ff96f89d329b9c23196c017400cde3bfb7a7e005406eff9adbee982c1be96a1186be44ee44feff1bb1db7753b5f80e0ce986384820968b215426f9d1c6d83bba95ad51267a1398807f16319ce177ea14a515f7a3ab743954297499a4ca1dce8d48dfb49fb751c1e5d117c35619d786194f4b5ed02ef443604068b67b87ba3a08408b0dc98696811e3c5fc6d71511af139d65edcf21b98000f812f46e554888b2e0d512055dec9362d398585addd51f22cd0f50746b7d6db778d2ef078fddfb14f2dbeb6165d57bd8b7d4761370b3c200f6d3f48f1c0cafa2e77edeb8afc35d734667311c75e46e5ac3ad5db4efc4277b3bf5d7706cef7523e6522d45d06de60119683274e0bdc52d548b76aa2094cec177d85a44466263e1381009330ba1a9890fac3d28f4e85fc944c239cea5f899022c5bdae0286b031bc009a451258e31d37029e3ef85399d781ac18026702215610b013f22e67f37d170d06e2c9e94de93d2b85e53da6a0c3922f37758427903ffd49c00cce02eb4105e2edd6551f499257af27b7375bd2ef0f658989e898e2f20942449cc28e421e000000fab8e174cf10dfa17f3df9c1
05-11 23:40:09.725+0200 I/WSM     ( 1149): WSM_I [Run, line = 150] Send reply to client.
05-11 23:40:09.725+0200 I/WSM     ( 1149): WSM_D [Run] Send reply =  [len=16492] 010000008003000006e27526d00deb5e9b174f8ac0b3bc74ff6c9ee9556b2a411ff3b1cc696c4ce9d1d27652e7bbd328d1246a6d83a58c28e2e62e2ccf5fb104c42daa423ff96f89d329b9c23196c017400cde3bfb7a7e005406eff9adbee982c1be96a1186be44ee44feff1bb1db7753b5f80e0ce986384820968b215426f9d1c6d83bba95ad51267a1398807f16319ce177ea14a515f7a3ab743954297499a4ca1dce8d48dfb49fb751c1e5d117c35619d786194f4b5ed02ef443604068b67b87ba3a08408b0dc98696811e3c5fc6d71511af139d65edcf21b98000f812f46e554888b2e0d512055dec9362d398585addd51f22cd0f50746b7d6db778d2ef078fddfb14f2dbeb6165d57bd8b7d4761370b3c200f6d3f48f1c0cafa2e77edeb8afc35d734667311c75e46e5ac3ad5db4efc4277b3bf5d7706cef7523e6522d45d06de60119683274e0bdc52d548b76aa2094cec177d85a44466263e1381009330ba1a9890fac3d28f4e85fc944c239cea5f899022c5bdae0286b031bc009a451258e31d37029e3ef85399d781ac18026702215610b013f22e67f37d170d06e2c9e94de93d2b85e53da6a0c3922f37758427903ffd49c00cce02eb4105e2edd6551f499257af27b7375bd2ef0f658989e898e2f20942449cc28e421e000000fab8e174cf10dfa17f3df9c19ee
05-11 23:40:09.735+0200 W/SHealthService(22892): SAPNotificationCallback.cpp: SAPNotiOnDataIndication(49) > [1;35muwServiceHandle:7, uwChannelId:999, uwPayloadLength: 447[0;m
05-11 23:40:09.735+0200 W/SHealthCommon(22892): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 0[0;m
05-11 23:40:09.735+0200 W/SHealthService(22892): SAPMessageDispatcher.cpp: GetHostMessageInfo(274) > [1;40;33mobject format[0;m
05-11 23:40:09.735+0200 W/SHealthCommon(22892): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (responseMessage)[0;m
05-11 23:40:09.735+0200 W/SHealthCommon(22892): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (message_type)[0;m
05-11 23:40:09.735+0200 W/SHealthCommon(22892): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (capability_type)[0;m
05-11 23:40:09.735+0200 W/SHealthCommon(22892): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_type)[0;m
05-11 23:40:09.735+0200 W/SHealthCommon(22892): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_feature)[0;m
05-11 23:40:09.735+0200 W/SHealthService(22892): SAPMessageDispatcher.cpp: Dispatch(200) > [1;40;33mAPP COMMAND MESSAGE!![0;m
05-11 23:40:09.735+0200 W/SHealthService(22892): AppCmdManager.cpp: OnSAPAppCommand(391) > [1;35mAPP COMMAND MESSAGE RECEIVER: com.samsung.tizengear.app.shealth.wearable.syncmanager, BODY SIZE[208] [0;m
05-11 23:40:09.735+0200 W/SHealthCommon(22892): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 1[0;m
05-11 23:40:09.735+0200 W/SHealthService(22892): CpuLock.cpp: CheckAndReset(125) > [1;40;33mREQUEST POWER LOCK CPU [180000][0;m
05-11 23:40:09.745+0200 W/SHealthService(22892): CommonSyncController.cpp: OnAppCommand(379) > [1;40;33mCommon Sync protocol type : 3[0;m
05-11 23:40:09.745+0200 W/SHealthService(22892): CommonSyncController.cpp: CommonSyncDispather(406) > [1;40;33mHOST_SYNC_MSG [ action : SYNC_DATA, result : SUCCESS,  ][ version : 4.510000, last_sync_time : 1494538168061,  ] [size: 164][0;m
05-11 23:40:09.750+0200 W/SHealthService(22892): CommonSyncController.cpp: CommonSyncDispather(415) > [1;40;33maction type : SYNC_DATA[0;m
05-11 23:40:09.750+0200 W/SHealthService(22892): CommonSyncController.cpp: CommonSyncDispather(493) > [1;40;33mresponse : SUCCESS[0;m
05-11 23:40:09.770+0200 W/SHealthCommon(22892): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
05-11 23:40:09.780+0200 W/SHealthCommon(22892): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
05-11 23:40:09.780+0200 W/SHealthService(22892): SAPV45MessageBuilder.cpp: MakeRequestDataRequestMsg(512) > [1;40;33mGEAR_SYNC_MSG [ action : REQUEST_DATA ][ device : Gear S2, device_type : 10032, version : 4.510000, last_sync_time : 1494538809761, reset_time : 1487887200000 ][0;m
05-11 23:40:09.790+0200 W/SHealthCommon(22892): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
05-11 23:40:09.790+0200 W/SHealthService(22892): SAP.cpp: SAPClientSend(423) > [1;40;33msend before message length [496][0;m
05-11 23:40:09.800+0200 W/SHealthService(22892): SAP.cpp: SAPClientSend(440) > [1;40;33msend data success !! message length = [496][0;m
05-11 23:40:09.800+0200 W/SHealthService(22892): SHealthServiceProxy.cpp: OnHostSendSuccess(148) > [1;35mmessage is sent successfully[0;m
05-11 23:40:09.800+0200 W/SHealthService(22892): SAPMessageDispatcher.cpp: OnHostMessageProgress(464) > [1;35msync progress [0][0;m
05-11 23:40:09.800+0200 I/WSM     ( 1149): WSM_I [Run, line = 118, thread  = 413d5460] Read request from client. 
05-11 23:40:09.800+0200 I/WSM     ( 1149): WSM_I [Run] Request len 406c 
05-11 23:40:09.800+0200 W/SHealthService(22892): CpuLock.cpp: CheckAndReset(128) > [1;40;33mRELEASE POWER LOCK CPU[0;m
05-11 23:40:09.800+0200 I/WSM     ( 1149): WSM_D [Run] Request data  =  [len=16492] 0004a04370030000a0ea58547b20226d65737361676522203a202252455155455354222c202273656e64657222203a2022636f6d2e73616d73756e672e74697a656e676561722e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c2022726563656976657222203a2022636f6d2e73616d73756e672e616e64726f69642e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c202276657273696f6e22203a20352e303039393939393939393939393939382c202264657669636522203a20223130303332222c202273657175656e63655f6e756d22203a203133322c20227479706522203a202244415441222c2022626f647922203a20224834734941414141414141414131324f7a5171444d4243455832584a5755723861324a765171586e566e7353436346755336427153594967785864766f7156493537627a7a62425477787449683862494277725633776343423669394b5675726874366635464b637230565a69574e653551526d6147414f664f53476f32722f617175333145346f4e5a51524358354a4f3730574646496152383465555a76766b325358306d7772377668544769764d314c6643716d35744a6c6d5378707a546a4f31446c39426f3047346f5a35797a69487174513648
05-11 23:40:09.810+0200 I/WSM     ( 1149): WSM_I [Run, line = 150] Send reply to client.
05-11 23:40:09.810+0200 I/WSM     ( 1149): WSM_D [Run] Send reply =  [len=16492] 010000007003000006e275267b20226d65737361676522203a202252455155455354222c202273656e64657222203a2022636f6d2e73616d73756e672e74697a656e676561722e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c2022726563656976657222203a2022636f6d2e73616d73756e672e616e64726f69642e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c202276657273696f6e22203a20352e303039393939393939393939393939382c202264657669636522203a20223130303332222c202273657175656e63655f6e756d22203a203133322c20227479706522203a202244415441222c2022626f647922203a20224834734941414141414141414131324f7a5171444d4243455832584a5755723861324a765171586e566e7353436346755336427153594967785864766f7156493537627a7a62425477787449683862494277725633776343423669394b5675726874366635464b637230565a69574e653551526d6147414f664f53476f32722f617175333145346f4e5a51524358354a4f3730574646496152383465555a76766b325358306d7772377668544769764d314c6643716d35744a6c6d5378707a546a4f31446c39426f3047346f5a35797a69487174513648354
05-11 23:40:10.010+0200 I/efl-extension(11482): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-11 23:40:10.010+0200 I/efl-extension( 4321): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-11 23:40:10.010+0200 I/efl-extension(  832): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-11 23:40:10.010+0200 I/efl-extension( 3611): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-11 23:40:10.010+0200 I/efl-extension(14310): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-11 23:40:10.010+0200 I/efl-extension(14310): efl_extension_rotary.c: _rotary_rotate_handler_cb(539) > Deliver counter clockwise rotary event to object: 0x437ec078, elm_layout, time_stamp : 121793021
05-11 23:40:10.010+0200 I/efl-extension(14310): efl_extension_rotary_selector.c: _rotary_selector_rotary_cb(628) > info->direction(1)
05-11 23:40:10.015+0200 I/efl-extension( 5755): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-11 23:40:10.015+0200 I/efl-extension(14310): efl_extension_rotary_selector.c: eext_rotary_selector_selected_item_get(2961) > called!!
05-11 23:40:10.015+0200 I/efl-extension(14310): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_get(2370) > called!!
05-11 23:40:10.015+0200 I/efl-extension(14310): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_get(2370) > called!!
05-11 23:40:10.015+0200 I/efl-extension(21196): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-11 23:40:10.015+0200 I/efl-extension( 4418): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-11 23:40:10.015+0200 I/efl-extension( 5745): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-11 23:40:10.015+0200 I/efl-extension( 3918): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-11 23:40:10.020+0200 I/efl-extension( 6230): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-11 23:40:10.055+0200 I/WSM     ( 1149): WSM_I [Run, line = 118, thread  = 413d5460] Read request from client. 
05-11 23:40:10.055+0200 I/WSM     ( 1149): WSM_I [Run] Request len 406c 
05-11 23:40:10.055+0200 I/WSM     ( 1149): WSM_D [Run] Request data  =  [len=16492] 0004a04380030000a0ea58548cefbbc39dabbf36fa89ec4a78820523b687037fc5bfb7906977c8b1d12eb3521c8c7b9379413b6dfac05e06c1e2a19bde1a9847c03ed8bcde05849113e5c2c28d7875a8cea8138c579ea48749e02a9c3fe03f95f7d33c4cca81f4c023622e4db483f230bf3ba4426a7cbfa3f1b000ce2c3ad1519dbf2796b55f569191a2f91ca8053ebe9ec3b1974618ac931df072a9ffaf30da579a0d415fdd4984c834cb5edc651f1f3290f85c634ca8654077ecb14044ccfc111b13b612e78a7237efffeeafe356121d71d07ab90f176392b7fbd3fcea27d29e3d0e33163376c59bf38e93264b7d3e32800bcb533614d142232c68e662b7091019984bcdba48f348e6b7ad0432b8345285ed567c5593ebb87a8e4bd2c9672e2732002922a0e36564810ca39e6ed41d3aca31908578529ce693f5dee7137c45ebaddd061351d2d671e5d5c329d128b5e4c40ace2546648799aa9715154c341564196d5668048f5c6b02a0d170322bc2d51d8cda94a38714c7a3bf0e4b2a7e879c2855aa5c7c9ffabb111fdcdb026cd66ea234cc7d5f763fc5cd4edbf3daaf4821804fa8133460c37f57011241de91ac8d7dc16a100cbd390600515669850f2cd09b12d63341d35f23a85f407ee47fe22200ce3904453940e092528d7ee58a1f000000231072ee2d23e84c
05-11 23:40:10.055+0200 I/WSM     ( 1149): WSM_I [Run, line = 150] Send reply to client.
05-11 23:40:10.055+0200 I/WSM     ( 1149): WSM_D [Run] Send reply =  [len=16492] 010000008003000006e275268cefbbc39dabbf36fa89ec4a78820523b687037fc5bfb7906977c8b1d12eb3521c8c7b9379413b6dfac05e06c1e2a19bde1a9847c03ed8bcde05849113e5c2c28d7875a8cea8138c579ea48749e02a9c3fe03f95f7d33c4cca81f4c023622e4db483f230bf3ba4426a7cbfa3f1b000ce2c3ad1519dbf2796b55f569191a2f91ca8053ebe9ec3b1974618ac931df072a9ffaf30da579a0d415fdd4984c834cb5edc651f1f3290f85c634ca8654077ecb14044ccfc111b13b612e78a7237efffeeafe356121d71d07ab90f176392b7fbd3fcea27d29e3d0e33163376c59bf38e93264b7d3e32800bcb533614d142232c68e662b7091019984bcdba48f348e6b7ad0432b8345285ed567c5593ebb87a8e4bd2c9672e2732002922a0e36564810ca39e6ed41d3aca31908578529ce693f5dee7137c45ebaddd061351d2d671e5d5c329d128b5e4c40ace2546648799aa9715154c341564196d5668048f5c6b02a0d170322bc2d51d8cda94a38714c7a3bf0e4b2a7e879c2855aa5c7c9ffabb111fdcdb026cd66ea234cc7d5f763fc5cd4edbf3daaf4821804fa8133460c37f57011241de91ac8d7dc16a100cbd390600515669850f2cd09b12d63341d35f23a85f407ee47fe22200ce3904453940e092528d7ee58a1f000000231072ee2d23e84cebd
05-11 23:40:10.075+0200 W/SHealthService(22892): SAPNotificationCallback.cpp: SAPNotiOnDataIndication(49) > [1;35muwServiceHandle:7, uwChannelId:999, uwPayloadLength: 451[0;m
05-11 23:40:10.075+0200 W/SHealthCommon(22892): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 0[0;m
05-11 23:40:10.075+0200 W/SHealthService(22892): SAPMessageDispatcher.cpp: GetHostMessageInfo(274) > [1;40;33mobject format[0;m
05-11 23:40:10.075+0200 W/SHealthCommon(22892): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (responseMessage)[0;m
05-11 23:40:10.075+0200 W/SHealthCommon(22892): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (message_type)[0;m
05-11 23:40:10.075+0200 W/SHealthCommon(22892): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (capability_type)[0;m
05-11 23:40:10.075+0200 W/SHealthCommon(22892): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_type)[0;m
05-11 23:40:10.075+0200 W/SHealthCommon(22892): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_feature)[0;m
05-11 23:40:10.075+0200 W/SHealthService(22892): SAPMessageDispatcher.cpp: Dispatch(200) > [1;40;33mAPP COMMAND MESSAGE!![0;m
05-11 23:40:10.075+0200 W/SHealthService(22892): AppCmdManager.cpp: OnSAPAppCommand(391) > [1;35mAPP COMMAND MESSAGE RECEIVER: com.samsung.tizengear.app.shealth.wearable.syncmanager, BODY SIZE[212] [0;m
05-11 23:40:10.075+0200 W/SHealthCommon(22892): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 1[0;m
05-11 23:40:10.075+0200 W/SHealthService(22892): CpuLock.cpp: CheckAndReset(125) > [1;40;33mREQUEST POWER LOCK CPU [179999][0;m
05-11 23:40:10.095+0200 W/SHealthService(22892): CommonSyncController.cpp: OnAppCommand(379) > [1;40;33mCommon Sync protocol type : 3[0;m
05-11 23:40:10.095+0200 W/SHealthService(22892): CommonSyncController.cpp: CommonSyncDispather(406) > [1;40;33mHOST_SYNC_MSG [ action : REQUEST_DATA, result : SUCCESS,  ][ version : 4.510000, last_sync_time : 1494538168061,  ] [size: 167][0;m
05-11 23:40:10.100+0200 W/SHealthService(22892): CommonSyncController.cpp: CommonSyncDispather(415) > [1;40;33maction type : REQUEST_DATA[0;m
05-11 23:40:10.100+0200 W/SHealthService(22892): CommonSyncController.cpp: CommonSyncDispather(548) > [1;40;33mresponse : SUCCESS[0;m
05-11 23:40:10.100+0200 W/SHealthService(22892): CpuLock.cpp: CheckAndReset(128) > [1;40;33mRELEASE POWER LOCK CPU[0;m
05-11 23:40:10.275+0200 I/efl-extension(14310): efl_extension_rotary_selector.c: _selector_animation_finished_cb(1795) > called!!
05-11 23:40:10.300+0200 I/WSM     ( 1149): WSM_I [Run, line = 118, thread  = 413d5460] Read request from client. 
05-11 23:40:10.300+0200 I/WSM     ( 1149): WSM_I [Run] Request len 406c 
05-11 23:40:10.300+0200 I/WSM     ( 1149): WSM_D [Run] Request data  =  [len=16492] 0004a04380030000a0ea585475f87e74cefd56cde8bf82bad22ba1d49b1ae551f778902695a51dd0845a7c9a0d911d773a28206596de21a53ecc7d6e24338b6d619d8e00601fd68305e4c3ccb0d7eb6fe356b6aaaa4a8d5acb68ffe8dd2e94a5f3a5a1ef715c3a79aef438836b2da787fb7ad9fcb0de6b6533aefb217c490a5002ad66b347f0bbd58f36062137433ff6f89af82b9486d57a71c947ebd7b7c03f956c884e20523ba59191937bc5b11e3eb3b4504ab67606bb9161e75ae865c48ec68cbc3b923a0c403a020933ef714d62497b81e003251d6dcb1317bf33d5140c4bac8a6605f5a8f9ea899b155d61ea09e16113304294609bf88b0fd00d7169740497bb8fb4816eaa483f6048bf512719b462a30f78979506080fff01b859ae2454350f32e0d67e9a3a97d658f586d34c196fc588f55c4f997a0f1dd9108557e0de0d693b9fbbce0975b6b86bb717ce0817b00e6d0223b7cd6187905ff92e349037f3c61a3aff3eddbd7f0f1231d6a5155c27b5c00ce8e1f49ab52d421acc22f312ab0e4dd17ab0af8bc3dcdf7d350266a15e0baa6b19b36d2124b5a6cd74dc351f7468603ae2f12b0201b96d7bbab7917f8baed7f54a5b898b16778a1c4a17bab27ee9fb512c01ec7d8611634376d6eba751d710bce790eea438a8181e10b3d4bd9537c11075110e14e342
05-11 23:40:10.300+0200 I/WSM     ( 1149): WSM_I [Run, line = 150] Send reply to client.
05-11 23:40:10.300+0200 I/WSM     ( 1149): WSM_D [Run] Send reply =  [len=16492] 010000008003000006e2752675f87e74cefd56cde8bf82bad22ba1d49b1ae551f778902695a51dd0845a7c9a0d911d773a28206596de21a53ecc7d6e24338b6d619d8e00601fd68305e4c3ccb0d7eb6fe356b6aaaa4a8d5acb68ffe8dd2e94a5f3a5a1ef715c3a79aef438836b2da787fb7ad9fcb0de6b6533aefb217c490a5002ad66b347f0bbd58f36062137433ff6f89af82b9486d57a71c947ebd7b7c03f956c884e20523ba59191937bc5b11e3eb3b4504ab67606bb9161e75ae865c48ec68cbc3b923a0c403a020933ef714d62497b81e003251d6dcb1317bf33d5140c4bac8a6605f5a8f9ea899b155d61ea09e16113304294609bf88b0fd00d7169740497bb8fb4816eaa483f6048bf512719b462a30f78979506080fff01b859ae2454350f32e0d67e9a3a97d658f586d34c196fc588f55c4f997a0f1dd9108557e0de0d693b9fbbce0975b6b86bb717ce0817b00e6d0223b7cd6187905ff92e349037f3c61a3aff3eddbd7f0f1231d6a5155c27b5c00ce8e1f49ab52d421acc22f312ab0e4dd17ab0af8bc3dcdf7d350266a15e0baa6b19b36d2124b5a6cd74dc351f7468603ae2f12b0201b96d7bbab7917f8baed7f54a5b898b16778a1c4a17bab27ee9fb512c01ec7d8611634376d6eba751d710bce790eea438a8181e10b3d4bd9537c11075110e14e3428b4
05-11 23:40:10.310+0200 W/SHealthService(22892): SAPNotificationCallback.cpp: SAPNotiOnDataIndication(49) > [1;35muwServiceHandle:7, uwChannelId:999, uwPayloadLength: 1585[0;m
05-11 23:40:10.310+0200 W/SHealthCommon(22892): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 0[0;m
05-11 23:40:10.310+0200 W/SHealthService(22892): SAPMessageDispatcher.cpp: GetHostMessageInfo(274) > [1;40;33mobject format[0;m
05-11 23:40:10.310+0200 W/SHealthCommon(22892): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (responseMessage)[0;m
05-11 23:40:10.310+0200 W/SHealthCommon(22892): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (message_type)[0;m
05-11 23:40:10.310+0200 W/SHealthCommon(22892): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (capability_type)[0;m
05-11 23:40:10.310+0200 W/SHealthCommon(22892): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_type)[0;m
05-11 23:40:10.310+0200 W/SHealthCommon(22892): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_feature)[0;m
05-11 23:40:10.310+0200 W/SHealthService(22892): SAPMessageDispatcher.cpp: Dispatch(200) > [1;40;33mAPP COMMAND MESSAGE!![0;m
05-11 23:40:10.310+0200 W/SHealthService(22892): AppCmdManager.cpp: OnSAPAppCommand(391) > [1;35mAPP COMMAND MESSAGE RECEIVER: com.samsung.tizengear.app.shealth.wearable.syncmanager, BODY SIZE[1348] [0;m
05-11 23:40:10.310+0200 W/SHealthCommon(22892): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 1[0;m
05-11 23:40:10.310+0200 W/SHealthService(22892): CpuLock.cpp: CheckAndReset(125) > [1;40;33mREQUEST POWER LOCK CPU [180000][0;m
05-11 23:40:10.325+0200 W/SHealthService(22892): CommonSyncController.cpp: OnAppCommand(379) > [1;40;33mCommon Sync protocol type : 3[0;m
05-11 23:40:10.325+0200 W/SHealthService(22892): CommonSyncController.cpp: CommonSyncDispather(406) > [1;40;33mHOST_SYNC_MSG [ action : SYNC_DATA,  ][ version : 4.510000, start_time : 0x45c1f2a0, end_time : 0x44b0cbb8, last_sync_time : 1494538168061, is_last_chunk : 1,  ] [size: 2208][0;m
05-11 23:40:10.325+0200 W/SHealthCommon(22892): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (result)[0;m
05-11 23:40:10.335+0200 W/SHealthService(22892): CommonSyncController.cpp: CommonSyncDispather(415) > [1;40;33maction type : SYNC_DATA[0;m
05-11 23:40:10.345+0200 W/SHealthCommon(22892): SystemUtil.cpp: IsShowCaseBinary(1220) > [1;35misShowCaseBinary : 0[0;m
05-11 23:40:10.365+0200 W/SHealthCommon(22892): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
05-11 23:40:10.375+0200 W/SHealthCommon(22892): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
05-11 23:40:10.375+0200 W/SHealthService(22892): SAPV45MessageBuilder.cpp: MakeCommonSyncResponseMsg(464) > [1;40;33mGEAR_SYNC_MSG [ action : SYNC_DATA , result : SUCCESS ][ device : Gear S2, device_type : 10032, version : 4.510000, last_sync_time : 1494538809761, reset_time : 1487887200000 ][0;m
05-11 23:40:10.380+0200 W/SHealthService(22892): SAP.cpp: SAPClientSend(423) > [1;40;33msend before message length [512][0;m
05-11 23:40:10.390+0200 W/SHealthService(22892): SAP.cpp: SAPClientSend(440) > [1;40;33msend data success !! message length = [512][0;m
05-11 23:40:10.390+0200 W/SHealthService(22892): SHealthServiceProxy.cpp: OnHostSendSuccess(148) > [1;35mmessage is sent successfully[0;m
05-11 23:40:10.390+0200 W/SHealthService(22892): SAPMessageDispatcher.cpp: OnHostMessageProgress(464) > [1;35msync progress [0][0;m
05-11 23:40:10.395+0200 I/WSM     ( 1149): WSM_I [Run, line = 118, thread  = 413d5460] Read request from client. 
05-11 23:40:10.395+0200 I/WSM     ( 1149): WSM_I [Run] Request len 406c 
05-11 23:40:10.395+0200 I/WSM     ( 1149): WSM_D [Run] Request data  =  [len=16492] 0004a04370030000a0ea58547b20226d65737361676522203a2022524553504f4e5345222c202273656e64657222203a2022636f6d2e73616d73756e672e74697a656e676561722e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c2022726563656976657222203a2022636f6d2e73616d73756e672e616e64726f69642e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c202276657273696f6e22203a20342e353039393939393939393939393939382c202264657669636522203a20223130303332222c202273657175656e63655f6e756d22203a2031302c20227479706522203a202244415441222c2022626f647922203a20224834734941414141414141414131324f537775444d4243452f38715373355434717245337361573358744965696b6749646c7343506f704a42536e2b3978726a515471332f575a6e64777234416d6c51612f6c436f64706e522b4141685957794d71707237556a342f5a4b4c5933624e6941656b522f32706a654f3350443978546d43434569625070683434714f72766b6d4e4c346f7979427837594f2b756d47642b4c35564d61426a4d65734e667233326758303351724e7675313145626f736132455559314c526d6b5568347a524e4e6e37726943
05-11 23:40:10.400+0200 I/WSM     ( 1149): WSM_I [Run, line = 150] Send reply to client.
05-11 23:40:10.400+0200 I/WSM     ( 1149): WSM_D [Run] Send reply =  [len=16492] 010000007003000006e275267b20226d65737361676522203a2022524553504f4e5345222c202273656e64657222203a2022636f6d2e73616d73756e672e74697a656e676561722e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c2022726563656976657222203a2022636f6d2e73616d73756e672e616e64726f69642e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c202276657273696f6e22203a20342e353039393939393939393939393939382c202264657669636522203a20223130303332222c202273657175656e63655f6e756d22203a2031302c20227479706522203a202244415441222c2022626f647922203a20224834734941414141414141414131324f537775444d4243452f38715373355434717245337361573358744965696b6749646c7343506f704a42536e2b3978726a515471332f575a6e64777234416d6c51612f6c436f64706e522b4141685957794d71707237556a342f5a4b4c5933624e6941656b522f32706a654f3350443978546d43434569625070683434714f72766b6d4e4c346f7979427837594f2b756d47642b4c35564d61426a4d65734e667233326758303351724e7675313145626f736132455559314c526d6b5568347a524e4e6e37726943616
05-11 23:40:10.405+0200 W/SHealthService(22892): SHealthSapSyncManager.cpp: NotifySAPSyncSuccess(152) > [1;35msync is completed[0;m
05-11 23:40:10.405+0200 W/SHealthCommon(22892): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: sync_done, pendingClientInfoList.size(): 0[0;m
05-11 23:40:10.405+0200 W/SHealthService(22892): CpuLock.cpp: CheckAndReset(128) > [1;40;33mRELEASE POWER LOCK CPU[0;m
05-11 23:40:10.410+0200 W/SHealthCommon(22892): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: SocialDataUpdatedServiceMessage, pendingClientInfoList.size(): 0[0;m
05-11 23:40:10.425+0200 W/SHealthCommon(22892): SocialStorage.cpp: GetEnabledChallengeTid(651) > [1;40;33mTID: 0 , Status : 0[0;m
05-11 23:40:10.425+0200 W/SHealthCommon(22892): SocialStorage.cpp: GetTogetherEnabled(695) > [1;40;33mServiceType: 1 , Status : 102[0;m
05-11 23:40:10.425+0200 W/SHealthCommon(22892): SocialStorage.cpp: GetTogetherEnabled(703) > [1;40;33mTogether Type[1] is enabled[0;m
05-11 23:40:10.425+0200 W/SHealthCommon(22892): SocialStorage.cpp: GetTogetherEnabled(695) > [1;40;33mServiceType: 1 , Status : 102[0;m
05-11 23:40:10.425+0200 W/SHealthCommon(22892): SocialStorage.cpp: GetTogetherEnabled(703) > [1;40;33mTogether Type[1] is enabled[0;m
05-11 23:40:10.425+0200 W/SHealthCommon(22892): SocialStorage.cpp: GetTogetherEnabled(695) > [1;40;33mServiceType: 2 , Status : 0[0;m
05-11 23:40:10.425+0200 W/SHealthCommon(22892): SocialStorage.cpp: GetTogetherEnabled(700) > [1;40;33mTogether Type[2] is disabled[0;m
05-11 23:40:10.425+0200 W/SHealthService(22892): SocialController.cpp: OnSocialDBDataChanged(770) > [1;40;33mPreferenceVersion[1001], togetherLeadOrChal[1], Stat[102], EnabledSocial[102], isEnabledLead[1], EnabledLead[102], isEnabledChal[0], EnabledChal[0][0;m
05-11 23:40:10.425+0200 W/SHealthCommon(22892): SocialStorage.cpp: GetTogetherEnabled(695) > [1;40;33mServiceType: 2 , Status : 0[0;m
05-11 23:40:10.425+0200 W/SHealthCommon(22892): SocialStorage.cpp: GetTogetherEnabled(700) > [1;40;33mTogether Type[2] is disabled[0;m
05-11 23:40:10.425+0200 W/SHealthService(22892): SocialController.cpp: OnSocialDBDataChanged(839) > [1;40;33mChallenge is disabled by mobile![0;m
05-11 23:40:10.435+0200 I/HealthDataService( 1051): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-11 23:40:10.445+0200 I/healthData(22892): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
05-11 23:40:10.565+0200 E/EFL     (14310): ecore_x<14310> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=121793576 button=1
05-11 23:40:10.635+0200 E/EFL     (14310): ecore_x<14310> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=121793643 button=1
05-11 23:40:10.880+0200 I/efl-extension(14310): efl_extension_rotary_selector.c: _selector_clicked_signal(1784) > called!!
05-11 23:40:10.880+0200 I/efl-extension(14310): efl_extension_rotary_selector.c: eext_rotary_selector_selected_item_get(2961) > called!!
05-11 23:40:10.880+0200 I/efl-extension(14310): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_get(2370) > called!!
05-11 23:40:10.880+0200 I/efl-extension(14310): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_get(2370) > called!!
05-11 23:40:11.235+0200 W/CRASH_MANAGER(14406): worker.c: worker_job(1205) > 111431073636f149453881
