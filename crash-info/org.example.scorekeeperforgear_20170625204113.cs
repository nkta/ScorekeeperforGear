S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.2
Build-Number: R732XXU2EQC1
Build-Date: 2017.03.13 20:32:41

Crash Information
Process Name: scorekeeperforgear
PID: 2665
Date: 2017-06-25 20:41:13+0200
Executable File Path: /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x28

Register Information
r0   = 0x00000000, r1   = 0xbec64338
r2   = 0x41457178, r3   = 0x418b5cd1
r4   = 0xbec64338, r5   = 0x418a14b0
r6   = 0x4031fb10, r7   = 0xbec64310
r8   = 0x4031116c, r9   = 0x0000027c
r10  = 0x403118e4, fp   = 0x403118e4
ip   = 0x401f2060, sp   = 0xbec64268
lr   = 0x418b5ced, pc   = 0x418ba290
cpsr = 0x20000030

Memory Information
MemTotal:   491132 KB
MemFree:      3724 KB
Buffers:     20036 KB
Cached:     137036 KB
VmPeak:     132396 KB
VmSize:     122732 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       31644 KB
VmRSS:       25672 KB
VmData:      63144 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23316 KB
VmPTE:          70 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 2665 TID = 2665
2665 2733 2734 2735 2736 

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
418cd000 418d2000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
418da000 418e6000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
418ef000 41910000 r-xp /usr/lib/libefl-extension.so.0.1.0
41918000 4191d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41925000 4194f000 r-xp /usr/lib/libsensor.so.1.9.5
41958000 4195f000 r-xp /usr/lib/libctx-shared.so.0.8.3
41967000 4196c000 r-xp /usr/lib/libctx-client.so.0.8.3
41974000 41986000 r-xp /usr/lib/libefl-assist.so.0.1.0
4198e000 41a46000 r-xp /usr/lib/libcairo.so.2.11200.14
41a51000 41a5b000 r-xp /usr/lib/libsensord-shared.so
41a63000 41a72000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
41a7b000 41a91000 r-xp /usr/lib/libtts.so
41a9a000 41abd000 r-xp /usr/lib/libui-extension.so.0.1.0
41ac6000 41ad1000 r-xp /usr/lib/libtbm.so.1.0.0
41ad9000 41ae7000 r-xp /usr/lib/libGLESv2.so.2.0
41af0000 41af1000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41afa000 41b00000 r-xp /usr/lib/libxcb-render.so.0.0.0
41b08000 41b0b000 r-xp /usr/lib/libEGL.so.1.4
41b13000 41b16000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41b1e000 41b1f000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41b28000 41cb0000 r-xp /usr/lib/libicui18n.so.57.1
41cc0000 41dc6000 r-xp /usr/lib/libicuuc.so.57.1
41ddc000 41de4000 r-xp /usr/lib/libdrm.so.2.4.0
41dec000 41dee000 r-xp /usr/lib/libdri2.so.0.0.0
41df6000 41dfc000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41e04000 41e09000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41e11000 41e2a000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
436cb000 436ec000 r-xp /usr/lib/libexif.so.12.3.3
436ff000 43701000 r-xp /usr/lib/libttrace.so.1.1
43709000 4370e000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43716000 4371c000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43725000 4372d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43735000 43757000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43760000 43767000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43770000 43772000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
4377a000 43781000 r-xp /usr/lib/libminizip.so.1.0.0
43789000 43796000 r-xp /usr/lib/libail.so.0.1.0
4379f000 437a5000 r-xp /usr/lib/libproc-stat.so.0.2.96
437ad000 437ae000 r-xp /usr/lib/libresponse.so.0.2.96
437b6000 437bb000 r-xp /usr/lib/libsystem.so.0.0.0
437c5000 4388f000 r-xp /usr/lib/libCOREGL.so.4.0
43bc1000 443c0000 rw-p [stack:2733]
443c1000 44bc0000 rw-p [stack:2734]
44bc1000 453c0000 rw-p [stack:2735]
453c0000 453cb000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
453d4000 453d9000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
453e2000 45be1000 rw-p [stack:2736]
45be1000 45bf8000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
45c05000 45c07000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
4648e000 4648f000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
bec44000 bec65000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2665)
Call Stack Count: 12
 0: $t.11 + 0x0 (0x418ba290) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x8290
 1: _rotary_event_cb(void*, _Eext_Rotary_Event_Info*) + 0x1c (0x418b5ced) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x3ced
 2: (0x41902a2b) [/usr/lib/libefl-extension.so.0] + 0x13a2b
 3: (0x402fae53) [/usr/lib/libecore.so.1] + 0x8e53
 4: (0x402fe46b) [/usr/lib/libecore.so.1] + 0xc46b
 5: ecore_main_loop_begin + 0x30 (0x402fe879) [/usr/lib/libecore.so.1] + 0xc879
 6: appcore_efl_main + 0x332 (0x40044b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
 7: ui_app_main + 0xb0 (0x41492421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 8: main + 0xc2 (0x418b577b) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x377b
 9: (0x40001a53) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x1a53
10: __libc_start_main + 0x114 (0x4049485c) [/lib/libc.so.6] + 0x1785c
11: (0x40001e0c) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x1e0c
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
FW_APPLICATION_PREFERENCE( 1326): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
06-25 20:41:11.655+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1326): preference.c: preference_get_double(1214) > preference_get_double(1326) : inactive_before_10min_precaution_millisec error
06-25 20:41:11.655+0200 W/SHealthService( 1326): SAPNotificationCallback.cpp: SAPNotiOnDataIndication(49) > [1;35muwServiceHandle:1, uwChannelId:999, uwPayloadLength: 334[0;m
06-25 20:41:11.655+0200 W/SHealthCommon( 1326): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 0[0;m
06-25 20:41:11.655+0200 W/SHealthService( 1326): SAPMessageDispatcher.cpp: GetHostMessageInfo(274) > [1;40;33mobject format[0;m
06-25 20:41:11.655+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (responseMessage)[0;m
06-25 20:41:11.655+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (message_type)[0;m
06-25 20:41:11.655+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (capability_type)[0;m
06-25 20:41:11.655+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_type)[0;m
06-25 20:41:11.655+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_feature)[0;m
06-25 20:41:11.655+0200 W/SHealthService( 1326): SAPMessageDispatcher.cpp: Dispatch(200) > [1;40;33mAPP COMMAND MESSAGE!![0;m
06-25 20:41:11.655+0200 W/SHealthService( 1326): AppCmdManager.cpp: OnSAPAppCommand(391) > [1;35mAPP COMMAND MESSAGE RECEIVER: com.samsung.tizengear.app.shealth.sport, BODY SIZE[124] [0;m
06-25 20:41:11.655+0200 W/SHealthCommon( 1326): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 0[0;m
06-25 20:41:11.655+0200 W/SHealthService( 1326): SportWearableMessageController.cpp: OnAppCommand(125) > [1;40;33mRECEIVE RESP MSG [Exercising_Status][0;m
06-25 20:41:11.655+0200 W/SHealthService( 1326): SportWearableMessageController.cpp: ProcessHostExerciseStopped(214) > [1;40;33mmIsHostExercisingRunning is already false[0;m
06-25 20:41:11.660+0200 I/WSM     ( 1162): WSM_I [Run, line = 118, thread  = 414d5460] Read request from client. 
06-25 20:41:11.660+0200 I/WSM     ( 1162): WSM_I [Run] Request len 406c 
06-25 20:41:11.660+0200 I/WSM     ( 1162): WSM_D [Run] Request data  =  [len=16492] e803a04380030000af01233e1b004a7c87f5f656c2862b1a72287a5c58b34a8d049c2004e448a8228b5b98800372abbdcdc2bebc32159bd26a7efa07250d0c4c54f8be76519939411a9318bd102d4904d3d2fd3dbcd93de6c5340277b1bbdbbe241519a2c293922940e0b615e677eb615d7015e342d00555d084ecb1adf73b4b6ad94d32b6720bbd1d21b9b952aca8a900ea3fc5888a7d18a31544b63f9449ee6be8ce7c225f576a2ae64bfd91c64498f9a7a3f6695097b0aadf236762bf934c02f1c8758edc24847e947a477cb50c3b98b3244a47031c094e2e1126cd6868a1926aace64bf50131b30cb937d15642ed387514385d651d4c26f91e26ba5b0b68849419f178232fe5ebd777de296ef08bcf4130644e32f3a479a1c12b8ac22f947826710e18c3da9fd9b21836e48d335c6ed18b6c49b1b6b05e1da78985ec751288bd122fbe22bd8a89afff609bffaa7a4d1e9b39182ec2f7b58926e4ac7efe770cc19b6293f10689da7eebdde1a07c45e5305922efcdf523b8d1d10847fa102c77a54014bd86c10dad38bbb25faa7b187040b59a62c4cb281278dfb5da9364f324000000082f9cfcb721a80faf28b4152d62cf34882eb74a791f8b4a17a9d0676ca1ff821357452ebca5dfdd0724a0da945599582068a10334632700fec2a40e599f425968765457506549
06-25 20:41:11.670+0200 I/WSM     ( 1162): WSM_I [Run, line = 150] Send reply to client.
06-25 20:41:11.670+0200 I/WSM     ( 1162): WSM_D [Run] Send reply =  [len=16492] 01000000800300009ef9f21e1b004a7c87f5f656c2862b1a72287a5c58b34a8d049c2004e448a8228b5b98800372abbdcdc2bebc32159bd26a7efa07250d0c4c54f8be76519939411a9318bd102d4904d3d2fd3dbcd93de6c5340277b1bbdbbe241519a2c293922940e0b615e677eb615d7015e342d00555d084ecb1adf73b4b6ad94d32b6720bbd1d21b9b952aca8a900ea3fc5888a7d18a31544b63f9449ee6be8ce7c225f576a2ae64bfd91c64498f9a7a3f6695097b0aadf236762bf934c02f1c8758edc24847e947a477cb50c3b98b3244a47031c094e2e1126cd6868a1926aace64bf50131b30cb937d15642ed387514385d651d4c26f91e26ba5b0b68849419f178232fe5ebd777de296ef08bcf4130644e32f3a479a1c12b8ac22f947826710e18c3da9fd9b21836e48d335c6ed18b6c49b1b6b05e1da78985ec751288bd122fbe22bd8a89afff609bffaa7a4d1e9b39182ec2f7b58926e4ac7efe770cc19b6293f10689da7eebdde1a07c45e5305922efcdf523b8d1d10847fa102c77a54014bd86c10dad38bbb25faa7b187040b59a62c4cb281278dfb5da9364f324000000082f9cfcb721a80faf28b4152d62cf34882eb74a791f8b4a17a9d0676ca1ff821357452ebca5dfdd0724a0da945599582068a10334632700fec2a40e599f425968765457506549334
06-25 20:41:11.675+0200 W/SHealthService( 1326): SAPNotificationCallback.cpp: SAPNotiOnDataIndication(49) > [1;35muwServiceHandle:1, uwChannelId:999, uwPayloadLength: 388[0;m
06-25 20:41:11.675+0200 W/SHealthCommon( 1326): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 0[0;m
06-25 20:41:11.675+0200 W/SHealthService( 1326): SAPMessageDispatcher.cpp: GetHostMessageInfo(274) > [1;40;33mobject format[0;m
06-25 20:41:11.675+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (responseMessage)[0;m
06-25 20:41:11.675+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (message_type)[0;m
06-25 20:41:11.675+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (capability_type)[0;m
06-25 20:41:11.675+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_type)[0;m
06-25 20:41:11.675+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_feature)[0;m
06-25 20:41:11.675+0200 W/SHealthService( 1326): SAPMessageDispatcher.cpp: Dispatch(200) > [1;40;33mAPP COMMAND MESSAGE!![0;m
06-25 20:41:11.675+0200 W/SHealthService( 1326): AppCmdManager.cpp: OnSAPAppCommand(391) > [1;35mAPP COMMAND MESSAGE RECEIVER: com.samsung.tizengear.app.shealth.social, BODY SIZE[176] [0;m
06-25 20:41:11.675+0200 W/SHealthCommon( 1326): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 0[0;m
06-25 20:41:11.675+0200 W/SHealthService( 1326): CpuLock.cpp: CheckAndReset(125) > [1;40;33mREQUEST POWER LOCK CPU [179999][0;m
06-25 20:41:11.690+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (update_time)[0;m
06-25 20:41:11.690+0200 W/SHealthService( 1326): CpuLock.cpp: CheckAndReset(128) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-25 20:41:12.070+0200 I/WSM     ( 1162): WSM_I [Run, line = 118, thread  = 414d5460] Read request from client. 
06-25 20:41:12.070+0200 I/WSM     ( 1162): WSM_I [Run] Request len 406c 
06-25 20:41:12.070+0200 I/WSM     ( 1162): WSM_D [Run] Request data  =  [len=16492] e803a04380030000af01233e39f7294166eb96dc83cd3efe63679728550c787d981d60c6c75677ced75f96ed140cfbef15378d856296e2199316da30cb7104ffa1d1de5c4500e30f7b8b2d9b34033d326dacefbb8a86b3557ebf59bac669c4e11bcedc1bd59d892f46c8182f7647ee02dce79c848cfc8aebeb96926be253d0742400715b13ba11bb7f12275e6b4f10b13ce7d037b4f7c24fdd977455d2192f4f6b5da01bc4e9184b74416df00ba1795a13e8dcecb9ffc938752a513061490611569560a219f076b4e9b92ace3dcc3428a773b11ccf0119af734931036ac0bd35f6abdde2280497d311a865fab86a50df4446bc36383d85cf2c0f34872bacdb60287ff9a46b526808825d65caa10cb5184d8f8db37683b23f219e6b4fb1ac66743348d6d82b497699c8728953faa0e0124d4ff7c0d4a0f97126960c9953d01cc78d3be6a17881fb567bef005ac5597bd98302f249a73444f68aa17cf9d576eb418055facdbff9d5b85f1a92ce089ab3b0c514cc9bf293a2a128dbbe3c30c89e46b1d7e38434b3adcf33bf1ddb3caf9aea4df259ca2214bc17c38ebd8e8532b5ed3505332a76a14ce5d2b3a740ba27831f6806c91956c1a9c47cd6f702b85a79d4693a4bd48ac7bc8258812a54b8f950d18442dc769609e5b22383250000008705b7d3c3af7ea68bda2c5e3c
06-25 20:41:12.080+0200 I/WSM     ( 1162): WSM_I [Run, line = 150] Send reply to client.
06-25 20:41:12.080+0200 I/WSM     ( 1162): WSM_D [Run] Send reply =  [len=16492] 01000000800300009ef9f21e39f7294166eb96dc83cd3efe63679728550c787d981d60c6c75677ced75f96ed140cfbef15378d856296e2199316da30cb7104ffa1d1de5c4500e30f7b8b2d9b34033d326dacefbb8a86b3557ebf59bac669c4e11bcedc1bd59d892f46c8182f7647ee02dce79c848cfc8aebeb96926be253d0742400715b13ba11bb7f12275e6b4f10b13ce7d037b4f7c24fdd977455d2192f4f6b5da01bc4e9184b74416df00ba1795a13e8dcecb9ffc938752a513061490611569560a219f076b4e9b92ace3dcc3428a773b11ccf0119af734931036ac0bd35f6abdde2280497d311a865fab86a50df4446bc36383d85cf2c0f34872bacdb60287ff9a46b526808825d65caa10cb5184d8f8db37683b23f219e6b4fb1ac66743348d6d82b497699c8728953faa0e0124d4ff7c0d4a0f97126960c9953d01cc78d3be6a17881fb567bef005ac5597bd98302f249a73444f68aa17cf9d576eb418055facdbff9d5b85f1a92ce089ab3b0c514cc9bf293a2a128dbbe3c30c89e46b1d7e38434b3adcf33bf1ddb3caf9aea4df259ca2214bc17c38ebd8e8532b5ed3505332a76a14ce5d2b3a740ba27831f6806c91956c1a9c47cd6f702b85a79d4693a4bd48ac7bc8258812a54b8f950d18442dc769609e5b22383250000008705b7d3c3af7ea68bda2c5e3cbfa
06-25 20:41:12.125+0200 W/SHealthService( 1326): SAPNotificationCallback.cpp: SAPNotiOnDataIndication(49) > [1;35muwServiceHandle:1, uwChannelId:999, uwPayloadLength: 446[0;m
06-25 20:41:12.125+0200 W/SHealthCommon( 1326): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 0[0;m
06-25 20:41:12.125+0200 W/SHealthService( 1326): SAPMessageDispatcher.cpp: GetHostMessageInfo(274) > [1;40;33mobject format[0;m
06-25 20:41:12.125+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (responseMessage)[0;m
06-25 20:41:12.125+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (message_type)[0;m
06-25 20:41:12.125+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (capability_type)[0;m
06-25 20:41:12.125+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_type)[0;m
06-25 20:41:12.125+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_feature)[0;m
06-25 20:41:12.125+0200 W/SHealthService( 1326): SAPMessageDispatcher.cpp: Dispatch(200) > [1;40;33mAPP COMMAND MESSAGE!![0;m
06-25 20:41:12.130+0200 W/SHealthService( 1326): AppCmdManager.cpp: OnSAPAppCommand(391) > [1;35mAPP COMMAND MESSAGE RECEIVER: com.samsung.tizengear.app.shealth.wearable.syncmanager, BODY SIZE[208] [0;m
06-25 20:41:12.135+0200 W/SHealthCommon( 1326): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 1[0;m
06-25 20:41:12.135+0200 W/SHealthService( 1326): CpuLock.cpp: CheckAndReset(125) > [1;40;33mREQUEST POWER LOCK CPU [179999][0;m
06-25 20:41:12.160+0200 W/SHealthService( 1326): CommonSyncController.cpp: OnAppCommand(379) > [1;40;33mCommon Sync protocol type : 3[0;m
06-25 20:41:12.160+0200 W/SHealthService( 1326): CommonSyncController.cpp: CommonSyncDispather(406) > [1;40;33mHOST_SYNC_MSG [ action : SYNC_DATA, result : SUCCESS,  ][ version : 4.510000, last_sync_time : 1498412005194,  ] [size: 164][0;m
06-25 20:41:12.170+0200 W/SHealthService( 1326): CommonSyncController.cpp: CommonSyncDispather(415) > [1;40;33maction type : SYNC_DATA[0;m
06-25 20:41:12.170+0200 W/SHealthService( 1326): CommonSyncController.cpp: CommonSyncDispather(493) > [1;40;33mresponse : SUCCESS[0;m
06-25 20:41:12.200+0200 W/SHealthCommon( 1326): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
06-25 20:41:12.210+0200 W/SHealthCommon( 1326): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
06-25 20:41:12.210+0200 W/SHealthService( 1326): SAPV45MessageBuilder.cpp: MakeRequestDataRequestMsg(512) > [1;40;33mGEAR_SYNC_MSG [ action : REQUEST_DATA ][ device : Gear S2, device_type : 10032, version : 4.510000, last_sync_time : 1498416072174, reset_time : 1487887200000 ][0;m
06-25 20:41:12.220+0200 W/SHealthCommon( 1326): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
06-25 20:41:12.220+0200 W/SHealthService( 1326): SAP.cpp: SAPClientSend(423) > [1;40;33msend before message length [495][0;m
06-25 20:41:12.235+0200 I/WSM     ( 1162): WSM_I [Run, line = 118, thread  = 414d5460] Read request from client. 
06-25 20:41:12.235+0200 I/WSM     ( 1162): WSM_I [Run] Request len 406c 
06-25 20:41:12.235+0200 I/WSM     ( 1162): WSM_D [Run] Request data  =  [len=16492] f003a04370030000af01233e7b20226d65737361676522203a202252455155455354222c202273656e64657222203a2022636f6d2e73616d73756e672e74697a656e676561722e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c2022726563656976657222203a2022636f6d2e73616d73756e672e616e64726f69642e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c202276657273696f6e22203a20352e303039393939393939393939393939382c202264657669636522203a20223130303332222c202273657175656e63655f6e756d22203a2032342c20227479706522203a202244415441222c2022626f647922203a20224834734941414141414141414131324f555175434d4253462f38706c7a784a7a72545a3745354b655333735347634e754d63675a626767532f766563526b6a6e375a3776484f34703451326b5165663041355778393562414163706736747162316f6154584c4c7a4e63734c6455794c6c4d414946597852694e79774e2f56666266486d32676c31427a6b6a30532f706839654d596b7133624c4a37374e7a3343642f73614c4b576e5068544f362f635947766c54624d3065534a35764b654378594a50695134642b685756516b7242614e4179464b6f50
06-25 20:41:12.235+0200 W/SHealthService( 1326): SAP.cpp: SAPClientSend(440) > [1;40;33msend data success !! message length = [495][0;m
06-25 20:41:12.235+0200 W/SHealthService( 1326): SHealthServiceProxy.cpp: OnHostSendSuccess(148) > [1;35mmessage is sent successfully[0;m
06-25 20:41:12.235+0200 W/SHealthService( 1326): SAPMessageDispatcher.cpp: OnHostMessageProgress(464) > [1;35msync progress [0][0;m
06-25 20:41:12.240+0200 W/SHealthService( 1326): CpuLock.cpp: CheckAndReset(128) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-25 20:41:12.240+0200 I/WSM     ( 1162): WSM_I [Run, line = 150] Send reply to client.
06-25 20:41:12.240+0200 I/WSM     ( 1162): WSM_D [Run] Send reply =  [len=16492] 01000000700300009ef9f21e7b20226d65737361676522203a202252455155455354222c202273656e64657222203a2022636f6d2e73616d73756e672e74697a656e676561722e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c2022726563656976657222203a2022636f6d2e73616d73756e672e616e64726f69642e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c202276657273696f6e22203a20352e303039393939393939393939393939382c202264657669636522203a20223130303332222c202273657175656e63655f6e756d22203a2032342c20227479706522203a202244415441222c2022626f647922203a20224834734941414141414141414131324f555175434d4253462f38706c7a784a7a72545a3745354b655333735347634e754d63675a626767532f766563526b6a6e375a3776484f34703451326b5165663041355778393562414163706736747162316f6154584c4c7a4e63734c6455794c6c4d414946597852694e79774e2f56666266486d32676c31427a6b6a30532f706839654d596b7133624c4a37374e7a3343642f73614c4b576e5068544f362f635947766c54624d3065534a35764b654378594a50695134642b685756516b7242614e4179464b6f50476
06-25 20:41:12.450+0200 I/WSM     ( 1162): WSM_I [Run, line = 118, thread  = 414d5460] Read request from client. 
06-25 20:41:12.450+0200 I/WSM     ( 1162): WSM_I [Run] Request len 406c 
06-25 20:41:12.450+0200 I/WSM     ( 1162): WSM_D [Run] Request data  =  [len=16492] f003a04380030000af01233ea1b2e3bcef605988c437fd6b0888574d3a4eed71edba616a880c5015ce7bf3ce0a9499814c498365e5b17840b74ec4f157331b733661b26ff793505c1f41c231ce569e5680c795418ca8432ceb4582faad1e322d4953ee484a20f25b78884ca9bd093ca591b06589718da3f9da55b2b1b343bd211a2ed14cce6657d5c5c83cea54b534a76e0f822473c690f891a46290fbf0923327382d66ea42169a753db640a58abae0ad6b897c82430e05fb7a890550e263cad70437cd587757c5188e450967ff0828820c6f2d84e814224d721ae60c461a5b7f3107ee84386df1941a7ceaccfabe7236b932c940f5afda387e3336dd2c633b9fbfec19975f12b295c08734ea9523353e5bb89cb66f089a35104ff9daed86de677ae0e636f242b86bdaad3187908ae188c4e89ceb6ced03d0ae3bcc651864ec6291f90eea442d6077adb477981b267fa2063eb055a10e6fcba4bce7b97ecd480613d88c0ec7045fd31665e0e57291628e96672d4f4a3a6451e47b9d9f8a23d3c9bbaecb50b8ad3cb550186a5e556b8789c81cf98ac88bc1a84519f1bc6b0133ecb290dcc06497dcf3af6c2f4eed764d6308171c2c771da3b4ea71c3a0ead8d11b7f5add3d8fd4a0ea8a012f968b019426000000566cc46e047fc42c90bfeae2d3b882ee90ec3f09795f61
06-25 20:41:12.465+0200 I/WSM     ( 1162): WSM_I [Run, line = 150] Send reply to client.
06-25 20:41:12.465+0200 I/WSM     ( 1162): WSM_D [Run] Send reply =  [len=16492] 01000000800300009ef9f21ea1b2e3bcef605988c437fd6b0888574d3a4eed71edba616a880c5015ce7bf3ce0a9499814c498365e5b17840b74ec4f157331b733661b26ff793505c1f41c231ce569e5680c795418ca8432ceb4582faad1e322d4953ee484a20f25b78884ca9bd093ca591b06589718da3f9da55b2b1b343bd211a2ed14cce6657d5c5c83cea54b534a76e0f822473c690f891a46290fbf0923327382d66ea42169a753db640a58abae0ad6b897c82430e05fb7a890550e263cad70437cd587757c5188e450967ff0828820c6f2d84e814224d721ae60c461a5b7f3107ee84386df1941a7ceaccfabe7236b932c940f5afda387e3336dd2c633b9fbfec19975f12b295c08734ea9523353e5bb89cb66f089a35104ff9daed86de677ae0e636f242b86bdaad3187908ae188c4e89ceb6ced03d0ae3bcc651864ec6291f90eea442d6077adb477981b267fa2063eb055a10e6fcba4bce7b97ecd480613d88c0ec7045fd31665e0e57291628e96672d4f4a3a6451e47b9d9f8a23d3c9bbaecb50b8ad3cb550186a5e556b8789c81cf98ac88bc1a84519f1bc6b0133ecb290dcc06497dcf3af6c2f4eed764d6308171c2c771da3b4ea71c3a0ead8d11b7f5add3d8fd4a0ea8a012f968b019426000000566cc46e047fc42c90bfeae2d3b882ee90ec3f09795f61a19
06-25 20:41:12.490+0200 W/SHealthService( 1326): SAPNotificationCallback.cpp: SAPNotiOnDataIndication(49) > [1;35muwServiceHandle:1, uwChannelId:999, uwPayloadLength: 436[0;m
06-25 20:41:12.490+0200 W/SHealthCommon( 1326): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 0[0;m
06-25 20:41:12.490+0200 W/SHealthService( 1326): SAPMessageDispatcher.cpp: GetHostMessageInfo(274) > [1;40;33mobject format[0;m
06-25 20:41:12.490+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (responseMessage)[0;m
06-25 20:41:12.490+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (message_type)[0;m
06-25 20:41:12.490+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (capability_type)[0;m
06-25 20:41:12.490+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_type)[0;m
06-25 20:41:12.490+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_feature)[0;m
06-25 20:41:12.490+0200 W/SHealthService( 1326): SAPMessageDispatcher.cpp: Dispatch(200) > [1;40;33mAPP COMMAND MESSAGE!![0;m
06-25 20:41:12.495+0200 W/SHealthService( 1326): AppCmdManager.cpp: OnSAPAppCommand(391) > [1;35mAPP COMMAND MESSAGE RECEIVER: com.samsung.tizengear.app.shealth.wearable.syncmanager, BODY SIZE[208] [0;m
06-25 20:41:12.500+0200 W/SHealthCommon( 1326): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 1[0;m
06-25 20:41:12.500+0200 W/SHealthService( 1326): CpuLock.cpp: CheckAndReset(125) > [1;40;33mREQUEST POWER LOCK CPU [180000][0;m
06-25 20:41:12.520+0200 W/SHealthService( 1326): CommonSyncController.cpp: OnAppCommand(379) > [1;40;33mCommon Sync protocol type : 3[0;m
06-25 20:41:12.520+0200 W/SHealthService( 1326): CommonSyncController.cpp: CommonSyncDispather(406) > [1;40;33mHOST_SYNC_MSG [ action : REQUEST_DATA, result : SUCCESS,  ][ version : 4.510000, last_sync_time : 1498412005194,  ] [size: 167][0;m
06-25 20:41:12.520+0200 W/SHealthService( 1326): CommonSyncController.cpp: CommonSyncDispather(415) > [1;40;33maction type : REQUEST_DATA[0;m
06-25 20:41:12.520+0200 W/SHealthService( 1326): CommonSyncController.cpp: CommonSyncDispather(548) > [1;40;33mresponse : SUCCESS[0;m
06-25 20:41:12.520+0200 W/SHealthService( 1326): CpuLock.cpp: CheckAndReset(128) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-25 20:41:12.750+0200 I/WSM     ( 1162): WSM_I [Run, line = 118, thread  = 414d5460] Read request from client. 
06-25 20:41:12.750+0200 I/WSM     ( 1162): WSM_I [Run] Request len 406c 
06-25 20:41:12.750+0200 I/WSM     ( 1162): WSM_D [Run] Request data  =  [len=16492] e803a04380030000af01233ee5c57bed199a635b5a1e7c50fff30df23920b437b40dd16225dd1be99acc31d5adbdd03a255265cb0b499743635882c07572f8798cd14a28b3b1b4885c2ff095ff55e61d73da9975703a7be3d4acfda0ac248d90399c9455919b92936a3486e01a1ee9a02aa039b5839f9e040b71d8a470ed862c910ae186430ce249c84dc810cd00b5396aa89fd94db9a8035364f5a27fd0e226d6c4093c1157faf5d5b106519c2c4e01bddf6e2d8acf47f6cd93181fa9e3e8b11ad3a831d231d17608bfd57e38d6342e24996502de0cf1b78202fe7a890778cc4c90d9aeb8080911038c4513c0df38789b1142dbdf238f77105b821aeaf427065be14c2f2e97c6309842b92f78b1e12cca719c3bccd5fbf3039b5fd9a362899659ea6677fb48a0e3536a14f7d1712455f426e67e2ef0d0f12a7f612a2c449f877365b9df52f41dafcc24260000d56938fc723c56a7be4427fae2d847141ee2b92574ac0f449cb1b5691c3d7cc3c5abe4a638f55d28b165a75069c27ca6d6bb05fe5b3e06887b504d31af293a2066f181a06f0754071d75fe153836863899fc872d5a4509e7be6c7c341ff296b6f730d00d5c9766a36c740ee340aa4f57ec9372797e443b2eeae3778409b708ce9ae1eb2182a579e518f265d272d1d850f46fb964a34c7d414194f1ed5676
06-25 20:41:12.760+0200 I/WSM     ( 1162): WSM_I [Run, line = 150] Send reply to client.
06-25 20:41:12.765+0200 I/WSM     ( 1162): WSM_D [Run] Send reply =  [len=16492] 01000000800300009ef9f21ee5c57bed199a635b5a1e7c50fff30df23920b437b40dd16225dd1be99acc31d5adbdd03a255265cb0b499743635882c07572f8798cd14a28b3b1b4885c2ff095ff55e61d73da9975703a7be3d4acfda0ac248d90399c9455919b92936a3486e01a1ee9a02aa039b5839f9e040b71d8a470ed862c910ae186430ce249c84dc810cd00b5396aa89fd94db9a8035364f5a27fd0e226d6c4093c1157faf5d5b106519c2c4e01bddf6e2d8acf47f6cd93181fa9e3e8b11ad3a831d231d17608bfd57e38d6342e24996502de0cf1b78202fe7a890778cc4c90d9aeb8080911038c4513c0df38789b1142dbdf238f77105b821aeaf427065be14c2f2e97c6309842b92f78b1e12cca719c3bccd5fbf3039b5fd9a362899659ea6677fb48a0e3536a14f7d1712455f426e67e2ef0d0f12a7f612a2c449f877365b9df52f41dafcc24260000d56938fc723c56a7be4427fae2d847141ee2b92574ac0f449cb1b5691c3d7cc3c5abe4a638f55d28b165a75069c27ca6d6bb05fe5b3e06887b504d31af293a2066f181a06f0754071d75fe153836863899fc872d5a4509e7be6c7c341ff296b6f730d00d5c9766a36c740ee340aa4f57ec9372797e443b2eeae3778409b708ce9ae1eb2182a579e518f265d272d1d850f46fb964a34c7d414194f1ed5676720
06-25 20:41:12.850+0200 W/SHealthService( 1326): SAPNotificationCallback.cpp: SAPNotiOnDataIndication(49) > [1;35muwServiceHandle:1, uwChannelId:999, uwPayloadLength: 1578[0;m
06-25 20:41:12.850+0200 W/SHealthCommon( 1326): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 0[0;m
06-25 20:41:12.850+0200 W/SHealthService( 1326): SAPMessageDispatcher.cpp: GetHostMessageInfo(274) > [1;40;33mobject format[0;m
06-25 20:41:12.850+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (responseMessage)[0;m
06-25 20:41:12.850+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (message_type)[0;m
06-25 20:41:12.850+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (capability_type)[0;m
06-25 20:41:12.850+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_type)[0;m
06-25 20:41:12.850+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_feature)[0;m
06-25 20:41:12.850+0200 W/SHealthService( 1326): SAPMessageDispatcher.cpp: Dispatch(200) > [1;40;33mAPP COMMAND MESSAGE!![0;m
06-25 20:41:12.850+0200 W/SHealthService( 1326): AppCmdManager.cpp: OnSAPAppCommand(391) > [1;35mAPP COMMAND MESSAGE RECEIVER: com.samsung.tizengear.app.shealth.wearable.syncmanager, BODY SIZE[1352] [0;m
06-25 20:41:12.865+0200 W/SHealthCommon( 1326): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 1[0;m
06-25 20:41:12.865+0200 W/SHealthService( 1326): CpuLock.cpp: CheckAndReset(125) > [1;40;33mREQUEST POWER LOCK CPU [180000][0;m
06-25 20:41:12.900+0200 W/SHealthService( 1326): CommonSyncController.cpp: OnAppCommand(379) > [1;40;33mCommon Sync protocol type : 3[0;m
06-25 20:41:12.905+0200 W/SHealthService( 1326): CommonSyncController.cpp: CommonSyncDispather(406) > [1;40;33mHOST_SYNC_MSG [ action : SYNC_DATA,  ][ version : 4.510000, start_time : 0x44ae6428, end_time : 0x44ae7cc8, last_sync_time : 1498412005194, is_last_chunk : 1,  ] [size: 2206][0;m
06-25 20:41:12.905+0200 W/SHealthCommon( 1326): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (result)[0;m
06-25 20:41:12.905+0200 W/SHealthService( 1326): CommonSyncController.cpp: CommonSyncDispather(415) > [1;40;33maction type : SYNC_DATA[0;m
06-25 20:41:12.920+0200 W/SHealthCommon( 1326): SystemUtil.cpp: IsShowCaseBinary(1220) > [1;35misShowCaseBinary : 0[0;m
06-25 20:41:12.955+0200 W/SHealthCommon( 1326): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
06-25 20:41:12.960+0200 W/SHealthCommon( 1326): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
06-25 20:41:12.970+0200 W/SHealthService( 1326): SAPV45MessageBuilder.cpp: MakeCommonSyncResponseMsg(464) > [1;40;33mGEAR_SYNC_MSG [ action : SYNC_DATA , result : SUCCESS ][ device : Gear S2, device_type : 10032, version : 4.510000, last_sync_time : 1498416072174, reset_time : 1487887200000 ][0;m
06-25 20:41:12.970+0200 W/SHealthService( 1326): SAP.cpp: SAPClientSend(423) > [1;40;33msend before message length [511][0;m
06-25 20:41:12.980+0200 I/WSM     ( 1162): WSM_I [Run, line = 118, thread  = 414d5460] Read request from client. 
06-25 20:41:12.980+0200 I/WSM     ( 1162): WSM_I [Run] Request len 406c 
06-25 20:41:12.980+0200 I/WSM     ( 1162): WSM_D [Run] Request data  =  [len=16492] f003a04370030000af01233e7b20226d65737361676522203a2022524553504f4e5345222c202273656e64657222203a2022636f6d2e73616d73756e672e74697a656e676561722e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c2022726563656976657222203a2022636f6d2e73616d73756e672e616e64726f69642e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c202276657273696f6e22203a20342e353039393939393939393939393939382c202264657669636522203a20223130303332222c202273657175656e63655f6e756d22203a20372c20227479706522203a202244415441222c2022626f647922203a20224834734941414141414141414131324f7a5172434d4243455832584a755567616f306d396c53726576455150556b6f494e55716750394c455170472b75303354513346752b38334f37755477425652726139564c53394d38577751487944315570544e743430636b3770644d48744e7269694a416e6261667967562b79374b54454168474b47434d664f71686531502b5851707354707931366b41516632665a644d4e37746d4b4d743254437665377338706475646a685a6930392b70617954646d684b365577646b6a54684e4e356a526d4a4751304874
06-25 20:41:12.985+0200 I/WSM     ( 1162): WSM_I [Run, line = 150] Send reply to client.
06-25 20:41:12.985+0200 I/WSM     ( 1162): WSM_D [Run] Send reply =  [len=16492] 01000000700300009ef9f21e7b20226d65737361676522203a2022524553504f4e5345222c202273656e64657222203a2022636f6d2e73616d73756e672e74697a656e676561722e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c2022726563656976657222203a2022636f6d2e73616d73756e672e616e64726f69642e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c202276657273696f6e22203a20342e353039393939393939393939393939382c202264657669636522203a20223130303332222c202273657175656e63655f6e756d22203a20372c20227479706522203a202244415441222c2022626f647922203a20224834734941414141414141414131324f7a5172434d4243455832584a755567616f306d396c53726576455150556b6f494e55716750394c455170472b75303354513346752b38334f37755477425652726139564c53394d38577751487944315570544e743430636b3770644d48744e7269694a416e6261667967562b79374b54454168474b47434d664f71686531502b5851707354707931366b41516632665a644d4e37746d4b4d743254437665377338706475646a685a6930392b70617954646d684b365577646b6a54684e4e356a526d4a4751304874566
06-25 20:41:12.990+0200 W/SHealthService( 1326): SAP.cpp: SAPClientSend(440) > [1;40;33msend data success !! message length = [511][0;m
06-25 20:41:12.990+0200 W/SHealthService( 1326): SHealthServiceProxy.cpp: OnHostSendSuccess(148) > [1;35mmessage is sent successfully[0;m
06-25 20:41:12.990+0200 W/SHealthService( 1326): SAPMessageDispatcher.cpp: OnHostMessageProgress(464) > [1;35msync progress [0][0;m
06-25 20:41:13.005+0200 W/SHealthService( 1326): SHealthSapSyncManager.cpp: NotifySAPSyncSuccess(152) > [1;35msync is completed[0;m
06-25 20:41:13.005+0200 W/SHealthCommon( 1326): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: sync_done, pendingClientInfoList.size(): 0[0;m
06-25 20:41:13.005+0200 W/SHealthService( 1326): CpuLock.cpp: CheckAndReset(128) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-25 20:41:13.020+0200 W/SHealthCommon( 1326): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: SocialDataUpdatedServiceMessage, pendingClientInfoList.size(): 0[0;m
06-25 20:41:13.025+0200 W/SHealthCommon( 1326): SocialStorage.cpp: GetEnabledChallengeTid(651) > [1;40;33mTID: 0 , Status : 0[0;m
06-25 20:41:13.025+0200 W/SHealthCommon( 1326): SocialStorage.cpp: GetTogetherEnabled(695) > [1;40;33mServiceType: 1 , Status : 102[0;m
06-25 20:41:13.025+0200 W/SHealthCommon( 1326): SocialStorage.cpp: GetTogetherEnabled(703) > [1;40;33mTogether Type[1] is enabled[0;m
06-25 20:41:13.035+0200 W/SHealthCommon( 1326): SocialStorage.cpp: GetTogetherEnabled(695) > [1;40;33mServiceType: 1 , Status : 102[0;m
06-25 20:41:13.035+0200 W/SHealthCommon( 1326): SocialStorage.cpp: GetTogetherEnabled(703) > [1;40;33mTogether Type[1] is enabled[0;m
06-25 20:41:13.035+0200 W/SHealthCommon( 1326): SocialStorage.cpp: GetTogetherEnabled(695) > [1;40;33mServiceType: 2 , Status : 0[0;m
06-25 20:41:13.035+0200 W/SHealthCommon( 1326): SocialStorage.cpp: GetTogetherEnabled(700) > [1;40;33mTogether Type[2] is disabled[0;m
06-25 20:41:13.035+0200 W/SHealthService( 1326): SocialController.cpp: OnSocialDBDataChanged(770) > [1;40;33mPreferenceVersion[1001], togetherLeadOrChal[1], Stat[102], EnabledSocial[102], isEnabledLead[1], EnabledLead[102], isEnabledChal[0], EnabledChal[0][0;m
06-25 20:41:13.035+0200 W/SHealthCommon( 1326): SocialStorage.cpp: GetTogetherEnabled(695) > [1;40;33mServiceType: 2 , Status : 0[0;m
06-25 20:41:13.035+0200 W/SHealthCommon( 1326): SocialStorage.cpp: GetTogetherEnabled(700) > [1;40;33mTogether Type[2] is disabled[0;m
06-25 20:41:13.035+0200 W/SHealthService( 1326): SocialController.cpp: OnSocialDBDataChanged(839) > [1;40;33mChallenge is disabled by mobile![0;m
06-25 20:41:13.040+0200 I/HealthDataService( 1036): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
06-25 20:41:13.060+0200 I/healthData( 1326): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
06-25 20:41:13.755+0200 I/efl-extension( 2665): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-25 20:41:13.755+0200 I/efl-extension( 2665): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x41810560, elm_layout, time_stamp : 4247980
06-25 20:41:13.755+0200 I/efl-extension( 2665): efl_extension_rotary_selector.c: _rotary_selector_rotary_cb(628) > info->direction(0)
06-25 20:41:13.755+0200 I/efl-extension( 2665): efl_extension_rotary_selector.c: eext_rotary_selector_selected_item_get(2961) > called!!
06-25 20:41:13.755+0200 I/efl-extension( 2665): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_get(2370) > called!!
06-25 20:41:13.755+0200 I/efl-extension( 2665): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_get(2370) > called!!
06-25 20:41:13.755+0200 I/efl-extension(  831): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-25 20:41:13.755+0200 I/efl-extension( 1339): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-25 20:41:13.895+0200 I/efl-extension(  831): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-25 20:41:13.895+0200 I/efl-extension( 1339): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-25 20:41:14.070+0200 I/efl-extension(  831): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-25 20:41:14.070+0200 I/efl-extension( 1339): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-25 20:41:14.270+0200 I/efl-extension(  831): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-25 20:41:14.270+0200 I/efl-extension( 1339): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
06-25 20:41:14.330+0200 W/STARTER (  742): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[831] goes to (3)
06-25 20:41:14.330+0200 E/STARTER (  742): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 831)'s state(3)
06-25 20:41:14.340+0200 W/AUL_AMD (  507): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-25 20:41:14.340+0200 W/AUL_AMD (  507): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
06-25 20:41:14.340+0200 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(831) status(fg) type(uiapp)
06-25 20:41:14.360+0200 W/PROCESSMGR(  469): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
06-25 20:41:14.370+0200 W/AUL_PAD ( 1331): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 2665 pgid = 2665
06-25 20:41:14.370+0200 W/AUL_PAD ( 1331): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
06-25 20:41:14.370+0200 W/W_HOME  (  831): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
06-25 20:41:14.370+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 20:41:14.370+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 20:41:14.375+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 20:41:14.375+0200 W/W_HOME  (  831): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 1
06-25 20:41:14.375+0200 W/W_INDICATOR(  743): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
06-25 20:41:14.375+0200 W/W_INDICATOR(  743): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-25 20:41:14.405+0200 W/W_HOME  (  831): event_manager.c: _window_visibility_cb(466) > Window [0x2800003] is now visible(0)
06-25 20:41:14.405+0200 W/W_HOME  (  831): event_manager.c: _window_visibility_cb(476) > state: 0 -> 1
06-25 20:41:14.405+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 20:41:14.405+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 20:41:14.405+0200 E/W_HOME  (  831): win.c: win_rotation_disable_set(186) > failed to get key VCONFKEY_DISABLE_ROTATION
06-25 20:41:14.405+0200 W/W_HOME  (  831): main.c: _window_visibility_cb(963) > Window [0x2800003] is now visible(0)
06-25 20:41:14.450+0200 I/APP_CORE(  831): appcore-efl.c: __do_app(453) > [APP 831] Event: RESUME State: PAUSED
06-25 20:41:14.450+0200 I/CAPI_APPFW_APPLICATION(  831): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-25 20:41:14.450+0200 W/W_HOME  (  831): main.c: _appcore_resume_cb(478) > appcore resume
06-25 20:41:14.450+0200 W/W_HOME  (  831): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
06-25 20:41:14.450+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 20:41:14.450+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 20:41:14.450+0200 W/W_HOME  (  831): main.c: home_resume(526) > journal_multimedia_screen_loaded_home called
06-25 20:41:14.450+0200 W/W_HOME  (  831): main.c: home_resume(530) > clock/widget resumed
06-25 20:41:14.450+0200 E/W_HOME  (  831): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
06-25 20:41:14.450+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 20:41:14.455+0200 I/wnotib  (  831): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 0
06-25 20:41:14.455+0200 E/wnotib  (  831): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
06-25 20:41:14.455+0200 W/wnotib  (  831): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
06-25 20:41:14.455+0200 W/W_INDICATOR(  743): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 1
06-25 20:41:14.455+0200 W/W_INDICATOR(  743): windicator_battery.c: windicator_battery_vconfkey_register(422) > [windicator_battery_vconfkey_register:422] Set battery cb
06-25 20:41:14.455+0200 W/W_INDICATOR(  743): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
06-25 20:41:14.465+0200 W/WATCH_CORE(  961): appcore-watch.c: __widget_resume(1124) > widget_resume
06-25 20:41:14.465+0200 W/AUL     (  961): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.watchface.TacticalSentry) pid(961) status(fg) type(watchapp)
06-25 20:41:14.465+0200 E/watchface-app(  961): watchface.cpp: OnAppResume(725) > 
06-25 20:41:14.465+0200 E/clock-component(  961): clock-component-alarm.c: _clock_component_alarm_get_lastest_alarm(176) > [0;31malarm_list is [(nil)][0;m
06-25 20:41:14.465+0200 I/watchface-viewer(  961): viewer-part-resource.cpp: Start(1276) > mState[3]
06-25 20:41:14.475+0200 I/CAPI_WATCH_APPLICATION(  961): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-25 20:41:14.475+0200 E/watchface-app(  961): watchface.cpp: OnAppTimeTick(744) > 
06-25 20:41:14.475+0200 I/watchface-viewer(  961): viewer-part-resource-evas.cpp: CreateTextImage(807) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=center ']
06-25 20:41:14.480+0200 I/watchface-viewer(  961): viewer-part-resource-evas.cpp: CreateTextImage(821) > formatted size 279x63
06-25 20:41:14.500+0200 I/watchface-viewer(  961): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(577) > ImagesLoadingDoneSignal().Emit()
06-25 20:41:14.500+0200 W/WATCH_CORE(  961): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
06-25 20:41:14.500+0200 I/WATCH_CORE(  961): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
06-25 20:41:14.500+0200 I/CAPI_WATCH_APPLICATION(  961): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-25 20:41:14.500+0200 E/watchface-app(  961): watchface.cpp: OnAppTimeTick(744) > 
06-25 20:41:14.500+0200 W/W_INDICATOR(  743): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(76), length(2)
06-25 20:41:14.500+0200 W/W_INDICATOR(  743): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 76%
06-25 20:41:14.500+0200 W/W_INDICATOR(  743): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 76, isCharging: 0
06-25 20:41:14.500+0200 W/W_INDICATOR(  743): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_80
06-25 20:41:14.500+0200 W/W_INDICATOR(  743): windicator_battery.c: windicator_battery_icon_update(381) > [windicator_battery_icon_update:381] Normal charging status !!
06-25 20:41:14.550+0200 W/AUL_PAD ( 1331): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
06-25 20:41:14.550+0200 I/AUL_AMD (  507): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 2665
06-25 20:41:14.550+0200 W/AUL     (  507): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(2665)
06-25 20:41:14.585+0200 I/efl-extension( 1339): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
06-25 20:41:14.585+0200 I/efl-extension(  831): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
06-25 20:41:14.585+0200 I/efl-extension(  831): efl_extension_rotary.c: _rotary_rotate_handler_cb(539) > Deliver counter clockwise rotary event to object: 0x460706e8, elm_box, time_stamp : 4248813
06-25 20:41:14.585+0200 I/wnotib  (  831): w-notification-board-broker-main.c: _wnotib_rotary_cb(559) > Pass rotary event to home.
06-25 20:41:14.590+0200 W/W_HOME  (  831): home_navigation.c: _rotary_cb(1168) > Detent detected, obj[0x46056818], direction[1]
06-25 20:41:14.615+0200 W/W_HOME  (  831): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-25 20:41:14.615+0200 W/W_HOME  (  831): home_navigation.c: _nav_finish_timer_add(850) > add timer:1
06-25 20:41:14.615+0200 W/W_HOME  (  831): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
06-25 20:41:14.615+0200 W/W_HOME  (  831): home_navigation.c: _is_rightedge(187) > (1080 360) not right edge: 0 0 0x47209f88 -> 360 0 0x460f9b70
06-25 20:41:14.620+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(633) > [0x46056818 : elm_scroller] rotary callabck is called.
06-25 20:41:14.620+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(663) > [0x46056818 : elm_scroller] block(2)
06-25 20:41:14.620+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(664) > [0x46056818 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
06-25 20:41:14.620+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(665) > [0x46056818 : elm_scroller] content size (w, h)(6120, 360)
06-25 20:41:14.620+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(666) > [0x46056818 : elm_scroller] viewport size (w, h)(360, 360)
06-25 20:41:14.620+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(730) > [0x46056818 : elm_scroller] CurrentPage(3) DetentValue(-1)
06-25 20:41:14.620+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(731) > [0x46056818 : elm_scroller] DetentCount(0)
06-25 20:41:14.620+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(407) > [0x46056818 : elm_scroller] mx(5760), my(0), minx(0), miny(0), px(1080), py(0)
06-25 20:41:14.620+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(407) > [0x46056818 : elm_scroller] mx(5760), my(0), minx(0), miny(0), px(1080), py(0)
06-25 20:41:14.620+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(407) > [0x46056818 : elm_scroller] mx(5760), my(0), minx(0), miny(0), px(1080), py(0)
06-25 20:41:14.620+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(763) > [0x46056818 : elm_scroller] bring in 2 page
06-25 20:41:14.620+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:5560 _elm_scroll_page_bring_in() [0x46056818 : elm_scroller] pagenumber_h(2), pagenumber_v(0)
06-25 20:41:14.620+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x46056818 : elm_scroller] mx(5760), my(0), minx(0), miny(0), px(1080), py(0)
06-25 20:41:14.620+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x46056818 : elm_scroller] cw(6120), ch(360), pw(360), ph(360)
06-25 20:41:14.620+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:1965 _elm_scroll_content_region_show_internal() [0x46056818 : elm_scroller] x(720), y(0), nx(720), px(1080), ny(0) py(0)
06-25 20:41:14.620+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:1991 _elm_scroll_content_region_show_internal() [0x46056818 : elm_scroller] x(720), y(0)
06-25 20:41:14.620+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:5578 _elm_scroll_page_bring_in() [0x46056818 : elm_scroller] _elm_scroll_content_region_show_internal() return TRUE!! x(720), y(0)
06-25 20:41:14.620+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2676 _elm_scroll_scroll_to_x() [0x46056818 : elm_scroller] t_in(0,270000), pos_x(720)
06-25 20:41:14.620+0200 W/W_HOME  (  831): home_navigation.c: _anim_start_cb(1290) > anim start
06-25 20:41:14.620+0200 W/W_HOME  (  831): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-25 20:41:14.620+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2629 _elm_scroll_scroll_to_y() [0x46056818 : elm_scroller] t_in(0,270000), pos_y(0)
06-25 20:41:14.620+0200 W/W_HOME  (  831): event_manager.c: _home_scroll_cb(585) > scroll,will,start
06-25 20:41:14.620+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 2, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 20:41:14.620+0200 W/W_HOME  (  831): event_manager.c: _home_scroll_cb(585) > scroll,start
06-25 20:41:14.620+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 3, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 20:41:14.645+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,373726)
06-25 20:41:14.645+0200 W/W_HOME  (  831): event_manager.c: _clock_view_obscured_cb(651) > state: 1 -> 0
06-25 20:41:14.645+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 3, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 20:41:14.650+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 3, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 20:41:14.655+0200 W/CRASH_MANAGER( 2766): worker.c: worker_job(1205) > 110266573636f149841607
