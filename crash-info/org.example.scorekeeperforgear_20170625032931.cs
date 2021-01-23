S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.2
Build-Number: R732XXU2EQC1
Build-Date: 2017.03.13 20:32:41

Crash Information
Process Name: scorekeeperforgear
PID: 14189
Date: 2017-06-25 03:29:31+0200
Executable File Path: /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x4

Register Information
r0   = 0x00000000, r1   = 0x418ba5ac
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xbe9da4c0, r5   = 0x41492980
r6   = 0x00000274, r7   = 0xbe9d9c48
r8   = 0x41450f48, r9   = 0x0000376d
r10  = 0x417b6210, fp   = 0x00000000
ip   = 0x418cbd8c, sp   = 0xbe9d9c40
lr   = 0x418b5991, pc   = 0x418b9c8e
cpsr = 0x20000030

Memory Information
MemTotal:   491132 KB
MemFree:      6280 KB
Buffers:      8808 KB
Cached:      98220 KB
VmPeak:      83832 KB
VmSize:      83828 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16628 KB
VmRSS:       16624 KB
VmData:      24244 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23316 KB
VmPTE:          50 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 14189 TID = 14189
14189 14198 14201 

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
43c0f000 4440e000 rw-p [stack:14198]
4440e000 4440f000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
445d6000 451ad000 rw-p [stack:14201]
be9ba000 be9db000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14189)
Call Stack Count: 19
 0: SensorProcess::getSensorValue() + 0x65 (0x418b9c8e) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x7c8e
 1: app_resume(void*) + 0x1c (0x418b5991) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x3991
 2: (0x41491bf9) [/usr/lib/libcapi-appfw-application.so.0] + 0x1bf9
 3: (0x400441ed) [/usr/lib/libappcore-efl.so.1] + 0x31ed
 4: (0x414a7d1f) [/usr/lib/libappcore-common.so.1] + 0x1d1f
 5: (0x4005a495) [/usr/lib/libaul.so.0] + 0x4495
 6: (0x4005afad) [/usr/lib/libaul.so.0] + 0x4fad
 7: (0x403bbfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
 8: g_main_context_dispatch + 0xbc (0x403bd7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
 9: (0x40302ca7) [/usr/lib/libecore.so.1] + 0x10ca7
10: (0x402fdb4f) [/usr/lib/libecore.so.1] + 0xbb4f
11: (0x402fe4d5) [/usr/lib/libecore.so.1] + 0xc4d5
12: ecore_main_loop_begin + 0x30 (0x402fe879) [/usr/lib/libecore.so.1] + 0xc879
13: appcore_efl_main + 0x332 (0x40044b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
14: ui_app_main + 0xb0 (0x41492421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
15: main + 0xc2 (0x418b56eb) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x36eb
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
sage(139) > [1;40;33mRoot node type : 0[0;m
06-25 03:29:39.504+0200 W/SHealthService( 1373): SportWearableMessageController.cpp: OnAppCommand(125) > [1;40;33mRECEIVE RESP MSG [Exercising_Status][0;m
06-25 03:29:39.524+0200 W/SHealthService( 1373): SportWearableMessageController.cpp: ProcessHostExerciseStopped(214) > [1;40;33mmIsHostExercisingRunning is already false[0;m
06-25 03:29:39.954+0200 I/WSM     ( 1178): WSM_I [Run, line = 118, thread  = 418b7460] Read request from client. 
06-25 03:29:39.954+0200 I/WSM     ( 1178): WSM_I [Run] Request len 406c 
06-25 03:29:39.954+0200 I/WSM     ( 1178): WSM_D [Run] Request data  =  [len=16492] 10f63240800300008be11c5d0167828bfb0c46f3114e77c8e91a54013e035a590a5747c122dffaa62219e21e1affd574b6d82816fb0c01b207c0be4703a13260dcc5cda8545cb7c3a3d046047a1dfb0c8e1fb23897745798e618f3d6cfdc3109c5cd0318086f018c57c1e05f3dfc9e0012084406f66c9cfbb199c6fa640cacb618a1c5454834509afe53b786411edc8d0892acda0d49de654e046a1141644a479161682b4d344dd34d05fd2ac4470420c147155243cf4f6c746b92a2823b64e029c4fa317b5fe4ece929235f8f0dd88f880b5b2a92f312b18fe507b653de4e5b456a5506861885ce3c1cd0444a3bd5917ab52b3af97fd1cada60d92efe7301972a11efb28954956768bd237bb7a8d9a0ccee3494d3f30f2a58fedaf8c188a9d1e8545d3700e5ec86d60954fc0f89f009e9bbf37984c1c0c8d932d1a9f538bc2631146d586f123870db1aa1c2146307ff4b27efa5f15c7647b6f0de6a672f322b19959acce5b84c108399feb025a71f5d4ebc6532850078842061f56a4631db1cb377008fa3757a5808a6b79fdec7d9f41b175a7e19742d10a6c373356cecd751e234e30f53c78ae6016cbe2cb956b3ec640e2ad751836b65bdbd133099a38f29be1c5c1d0285765ff115003f417f3c4658b82de2d98f3ac7c96fcc499da73583a0a90e63a93e03cf1aac50
06-25 03:29:39.954+0200 I/WSM     ( 1178): WSM_I [Run, line = 150] Send reply to client.
06-25 03:29:39.954+0200 I/WSM     ( 1178): WSM_D [Run] Send reply =  [len=16492] 01000000800300006533d27d0167828bfb0c46f3114e77c8e91a54013e035a590a5747c122dffaa62219e21e1affd574b6d82816fb0c01b207c0be4703a13260dcc5cda8545cb7c3a3d046047a1dfb0c8e1fb23897745798e618f3d6cfdc3109c5cd0318086f018c57c1e05f3dfc9e0012084406f66c9cfbb199c6fa640cacb618a1c5454834509afe53b786411edc8d0892acda0d49de654e046a1141644a479161682b4d344dd34d05fd2ac4470420c147155243cf4f6c746b92a2823b64e029c4fa317b5fe4ece929235f8f0dd88f880b5b2a92f312b18fe507b653de4e5b456a5506861885ce3c1cd0444a3bd5917ab52b3af97fd1cada60d92efe7301972a11efb28954956768bd237bb7a8d9a0ccee3494d3f30f2a58fedaf8c188a9d1e8545d3700e5ec86d60954fc0f89f009e9bbf37984c1c0c8d932d1a9f538bc2631146d586f123870db1aa1c2146307ff4b27efa5f15c7647b6f0de6a672f322b19959acce5b84c108399feb025a71f5d4ebc6532850078842061f56a4631db1cb377008fa3757a5808a6b79fdec7d9f41b175a7e19742d10a6c373356cecd751e234e30f53c78ae6016cbe2cb956b3ec640e2ad751836b65bdbd133099a38f29be1c5c1d0285765ff115003f417f3c4658b82de2d98f3ac7c96fcc499da73583a0a90e63a93e03cf1aac501b1
06-25 03:29:39.959+0200 W/SHealthService( 1373): SAPNotificationCallback.cpp: SAPNotiOnDataIndication(49) > [1;35muwServiceHandle:4, uwChannelId:999, uwPayloadLength: 1585[0;m
06-25 03:29:40.049+0200 W/SHealthCommon( 1373): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 0[0;m
06-25 03:29:40.049+0200 W/SHealthService( 1373): SAPMessageDispatcher.cpp: GetHostMessageInfo(274) > [1;40;33mobject format[0;m
06-25 03:29:40.049+0200 W/SHealthCommon( 1373): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (responseMessage)[0;m
06-25 03:29:40.049+0200 W/SHealthCommon( 1373): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (message)[0;m
06-25 03:29:40.049+0200 W/SHealthCommon( 1373): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_type)[0;m
06-25 03:29:40.049+0200 W/SHealthCommon( 1373): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_feature)[0;m
06-25 03:29:40.049+0200 W/SHealthService( 1373): SAPMessageDispatcher.cpp: Dispatch(173) > [1;40;33mSHealth Capability message[0;m
06-25 03:29:40.049+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1373): preference.c: _preference_check_retry_err(507) > key(debug_wearable_message), check retry err: -21/(2/No such file or directory).
06-25 03:29:40.049+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1373): preference.c: _preference_get_key(1101) > _preference_get_key(debug_wearable_message) step(-17825744) failed(2 / No such file or directory)
06-25 03:29:40.049+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1373): preference.c: preference_get_boolean(1173) > preference_get_boolean(1373) : debug_wearable_message error
06-25 03:29:40.164+0200 W/SHealthCommon( 1373): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
06-25 03:29:40.164+0200 W/SHealthService( 1373): SAPCapabilityManager.cpp: OnSAPCapabilityMessageReceived(1428) > [1;40;33mHost SHealth version : 5720029,000000[0;m
06-25 03:29:40.164+0200 W/SHealthCommon( 1373): PreferenceManager.cpp: SetMobileSHealthVersion(1021) > [1;35mMobileSHealthVersion: 0,000000[0;m
06-25 03:29:40.169+0200 W/SHealthCommon( 1373): PreferenceManager.cpp: SetMobileSHealthVersion(1021) > [1;35mMobileSHealthVersion: 5720029,000000[0;m
06-25 03:29:40.279+0200 W/WRT_PLUGINS/TIZEN(17384): SystemInfoCpu.cpp: fetchLoad(76) > Cannot calculate cpu load, previous value returned
06-25 03:29:40.319+0200 W/SHealthCommon( 1373): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
06-25 03:29:40.329+0200 W/SHealthCommon( 1373): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
06-25 03:29:40.329+0200 W/SHealthService( 1373): SAPCapabilityManager.cpp: CastHostTrackerFeatureCapabilityUpdatedEvent(1376) > [1;35mCastHostTrackerFeatureCapabilityUpdatedEvent[0;m
06-25 03:29:40.434+0200 W/SHealthService( 1373): WaterCaffeineController.cpp: OnHostTrackerFeatureCapabilityUpdated(130) > [1;35misHostSupportWaterMinus: 1, isHostSupportCaffeineMinus: 1, isHostSupportWaterAmount : 1, isHostSupportCaffeineAmount : 1[0;m
06-25 03:29:40.469+0200 W/SHealthService( 1373): DirectShareController.cpp: OnHostTrackerFeatureCapabilityUpdated(260) > [1;40;33m[tracker_type] is not available in capability. Set default SPORT:[1,2,3] only.[0;m
06-25 03:29:40.469+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1373): preference.c: _preference_check_retry_err(507) > key(together_prod_list_support), check retry err: -21/(2/No such file or directory).
06-25 03:29:40.469+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1373): preference.c: _preference_get_key(1101) > _preference_get_key(together_prod_list_support) step(-17825744) failed(2 / No such file or directory)
06-25 03:29:40.469+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1373): preference.c: preference_get_boolean(1173) > preference_get_boolean(1373) : together_prod_list_support error
06-25 03:29:40.479+0200 W/SHealthCommon( 1373): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
06-25 03:29:40.509+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1373): preference.c: _preference_check_retry_err(507) > key(host_together_supported), check retry err: -21/(2/No such file or directory).
06-25 03:29:40.509+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1373): preference.c: _preference_get_key(1101) > _preference_get_key(host_together_supported) step(-17825744) failed(2 / No such file or directory)
06-25 03:29:40.509+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1373): preference.c: preference_get_boolean(1173) > preference_get_boolean(1373) : host_together_supported error
06-25 03:29:40.524+0200 W/SHealthCommon( 1373): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
06-25 03:29:40.524+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1373): preference.c: _preference_check_retry_err(507) > key(host_together_supported), check retry err: -21/(2/No such file or directory).
06-25 03:29:40.524+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1373): preference.c: _preference_get_key(1101) > _preference_get_key(host_together_supported) step(-17825744) failed(2 / No such file or directory)
06-25 03:29:40.524+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1373): preference.c: preference_get_boolean(1173) > preference_get_boolean(1373) : host_together_supported error
06-25 03:29:40.534+0200 I/APP_CORE(  840): appcore-efl.c: __do_app(453) > [APP 840] Event: MEM_FLUSH State: PAUSED
06-25 03:29:40.559+0200 W/SHealthService( 1373): SocialController.cpp: OnHostTrackerFeatureCapabilityUpdated(686) > [1;40;33mmNegotiatedFeatureCapabilityVersion[1010], hostChallengeNudgeListSupport[0], hostServerSyncTriggerSupport[1][0;m
06-25 03:29:40.559+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1373): preference.c: _preference_check_retry_err(507) > key(disclaimer), check retry err: -21/(2/No such file or directory).
06-25 03:29:40.559+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1373): preference.c: _preference_get_key(1101) > _preference_get_key(disclaimer) step(-17825744) failed(2 / No such file or directory)
06-25 03:29:40.559+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1373): preference.c: preference_get_boolean(1173) > preference_get_boolean(1373) : disclaimer error
06-25 03:29:40.589+0200 W/SHealthCommon( 1373): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
06-25 03:29:40.589+0200 W/SHealthService( 1373): SAP.cpp: SAPClientSend(423) > [1;40;33msend before message length [381][0;m
06-25 03:29:40.614+0200 W/SHealthService( 1373): SAP.cpp: SAPClientSend(440) > [1;40;33msend data success !! message length = [381][0;m
06-25 03:29:40.614+0200 I/WSM     ( 1178): WSM_I [Run, line = 118, thread  = 418b7460] Read request from client. 
06-25 03:29:40.614+0200 W/SHealthService( 1373): SHealthServiceProxy.cpp: OnHostSendSuccess(148) > [1;35mmessage is sent successfully[0;m
06-25 03:29:40.614+0200 I/WSM     ( 1178): WSM_I [Run] Request len 406c 
06-25 03:29:40.614+0200 W/SHealthService( 1373): SAPMessageDispatcher.cpp: OnHostMessageProgress(464) > [1;35msync progress [0][0;m
06-25 03:29:40.614+0200 I/WSM     ( 1178): WSM_D [Run] Request data  =  [len=16492] 10f63240700300008be11c5d7b20226d65737361676522203a202252455155455354222c202273656e64657222203a2022636f6d2e73616d73756e672e74697a656e676561722e6170702e736865616c74682e736f6369616c222c2022726563656976657222203a2022636f6d2e73616d73756e672e6d6f62696c652e6170702e736865616c74682e736f6369616c222c202276657273696f6e22203a20352e303039393939393939393939393939382c202264657669636522203a20223130303332222c202273657175656e63655f6e756d22203a2035352c20227479706522203a20224d455353414745222c2022626f647922203a2022483473494141414141414141413674575543704c4c53724f7a4d3954557242534d4451774e4e42525545724c4c30704f6a53387453456b735351554a5679736f4a536158514e556f75666b484f627647687761344f49613478676535426f6136426f636f4158575656426141565373427453556d4a5259444f62554b74514330576a41475951414141413d3d22207d000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
06-25 03:29:40.619+0200 I/WSM     ( 1178): WSM_I [Run, line = 150] Send reply to client.
06-25 03:29:40.619+0200 I/WSM     ( 1178): WSM_D [Run] Send reply =  [len=16492] 01000000700300006533d27d7b20226d65737361676522203a202252455155455354222c202273656e64657222203a2022636f6d2e73616d73756e672e74697a656e676561722e6170702e736865616c74682e736f6369616c222c2022726563656976657222203a2022636f6d2e73616d73756e672e6d6f62696c652e6170702e736865616c74682e736f6369616c222c202276657273696f6e22203a20352e303039393939393939393939393939382c202264657669636522203a20223130303332222c202273657175656e63655f6e756d22203a2035352c20227479706522203a20224d455353414745222c2022626f647922203a2022483473494141414141414141413674575543704c4c53724f7a4d3954557242534d4451774e4e42525545724c4c30704f6a53387453456b735351554a5679736f4a536158514e556f75666b484f627647687761344f49613478676535426f6136426f636f4158575656426141565373427453556d4a5259444f62554b74514330576a41475951414141413d3d22207d000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
06-25 03:29:40.639+0200 W/SHealthService( 1373): CommonSyncStorage.cpp: RecoverCommonSyncDuration(244) > [1;35mUpdated all 'shealth_common_sync_duration' start_time to 1495749600000,000000[0;m
06-25 03:29:40.639+0200 W/SHealthService( 1373): CommonSyncStorage.cpp: RecoverCommonSyncDurationThatHasEndtimeBiggerThanCurrentTime(298) > [1;35mUpdated all 'shealth_common_sync_duration' end_time to 1498354180644,000000[0;m
06-25 03:29:40.639+0200 W/SHealthService( 1373): CommonSyncStorage.cpp: RemoveCommonSyncDurationThatHasStartTimeBiggerThanEndTime(328) > [1;35mRemoved all where start_time is bigger than end_time[0;m
06-25 03:29:40.639+0200 W/SHealthService( 1373): CommonSyncStorage.cpp: RecoverCommonSyncDurationForSyncTimeException(273) > [1;35mUpdated syncTimeException true records endtime to [1495749600000,000000][0;m
06-25 03:29:40.639+0200 W/SHealthService( 1373): CommonSyncController.cpp: CommonSyncStart(175) > [1;35mRequest cpu lock[0;m
06-25 03:29:40.639+0200 W/SHealthService( 1373): CpuLock.cpp: CheckAndReset(125) > [1;40;33mREQUEST POWER LOCK CPU [180000][0;m
06-25 03:29:40.669+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1373): preference.c: _preference_check_retry_err(507) > key(maximum_long_term_sync_score), check retry err: -21/(2/No such file or directory).
06-25 03:29:40.669+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1373): preference.c: _preference_get_key(1101) > _preference_get_key(maximum_long_term_sync_score) step(-17825744) failed(2 / No such file or directory)
06-25 03:29:40.669+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1373): preference.c: preference_get_double(1214) > preference_get_double(1373) : maximum_long_term_sync_score error
06-25 03:29:40.669+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1373): preference.c: _preference_check_retry_err(507) > key(chunk_per_hour), check retry err: -21/(2/No such file or directory).
06-25 03:29:40.669+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1373): preference.c: _preference_get_key(1101) > _preference_get_key(chunk_per_hour) step(-17825744) failed(2 / No such file or directory)
06-25 03:29:40.669+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1373): preference.c: preference_get_int(1132) > preference_get_int(1373) : key(chunk_per_hour) error
06-25 03:29:40.669+0200 W/SHealthService( 1373): CommonSyncMakingTableInfo.cpp: GetStartOfTImeByScoreV45(212) > [1;40;33mstartTime[1498333122938,000000], endTime[1498354180618,000000], maxiumScore[3145728], chunkPerHour[1][0;m
06-25 03:29:40.689+0200 W/SHealthService( 1373): CommonSyncMakingTableInfo.cpp: GetStartOfTImeByScoreV45(223) > [1;40;33mestimateStartTime[1498330800000,000000], scoreStartTime[1498333122938,000000], scoreEndTime[1498354180618,000000], score[15890,000000][0;m
06-25 03:29:40.689+0200 W/SHealthService( 1373): CpuLock.cpp: CheckAndReset(128) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-25 03:29:40.699+0200 W/SHealthService( 1373): CommonSyncController.cpp: CommonSyncStart(228) > [1;35mRelease cpu lock[0;m
06-25 03:29:40.699+0200 W/SHealthService( 1373): CommonSyncController.cpp: CommonSyncStart(234) > [1;35mRequest cpu lock[0;m
06-25 03:29:40.709+0200 W/SHealthService( 1373): CpuLock.cpp: CheckAndReset(125) > [1;40;33mREQUEST POWER LOCK CPU [180000][0;m
06-25 03:29:40.734+0200 W/SHealthService( 1373): SAPV45MessageBuilder.cpp: MakeCommonSyncRequestMsg(169) > [1;40;33mstarTime: 1498333122938,000000, endTime: 1498354180618,000000, isLastChunk: 1, isMobileSHealthReset&sendMobileData: 1[0;m
06-25 03:29:40.749+0200 W/SHealthCommon( 1373): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
06-25 03:29:40.759+0200 W/SHealthCommon( 1373): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
06-25 03:29:40.769+0200 W/SHealthService( 1373): SAPV45MessageBuilder.cpp: MakeUserProfileJsonArray(665) > [1;35mdon't send profile item / createTime [1471603931892,000000] / updateTime [0,000000] / uuid [00000000-0000-0000-0000-000000000014][0;m
06-25 03:29:40.769+0200 W/SHealthService( 1373): SAPV45MessageBuilder.cpp: MakeHeartRateJsonArray(755) > [1;40;33mHeartRate is empty[0;m
06-25 03:29:40.789+0200 W/SHealthService( 1373): SAPV45MessageBuilder.cpp: MakePedoEventJsonArray(885) > [1;40;33mpedo event is empty[0;m
06-25 03:29:40.854+0200 W/SHealthService( 1373): SAPV45MessageBuilder.cpp: MakeCommonSyncRequestMsg(325) > [1;40;33mGEAR_SYNC_MSG [ action : SYNC_DATA ][ device : Gear S2, device_type : 10032, version : 4.510000, start_time : 1498333122938, end_time : 1498354180618, last_sync_time : 1498333125340, is_last_chunk : 1, reset_time : 1487887200000 ] [size: 14011][0;m
06-25 03:29:40.884+0200 W/SHealthCommon( 1373): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
06-25 03:29:40.899+0200 W/SHealthService( 1373): SAP.cpp: SAPClientSend(423) > [1;40;33msend before message length [4091][0;m
06-25 03:29:40.934+0200 W/SHealthService( 1373): SAP.cpp: SAPClientSend(440) > [1;40;33msend data success !! message length = [4091][0;m
06-25 03:29:40.934+0200 I/WSM     ( 1178): WSM_I [Run, line = 118, thread  = 418b7460] Read request from client. 
06-25 03:29:40.934+0200 I/WSM     ( 1178): WSM_I [Run] Request len 406c 
06-25 03:29:40.934+0200 W/SHealthService( 1373): SHealthServiceProxy.cpp: OnHostSendSuccess(148) > [1;35mmessage is sent successfully[0;m
06-25 03:29:40.934+0200 W/SHealthService( 1373): SAPMessageDispatcher.cpp: OnHostMessageProgress(464) > [1;35msync progress [0][0;m
06-25 03:29:40.934+0200 I/WSM     ( 1178): WSM_D [Run] Request data  =  [len=16492] 10f63240700300008be11c5d78da8d57c70ec4c86efc95c55e65acb234f24d39e7ac8ba19c4639cbf0bf7b761f0cf8e08379647717293659d5facf3ffe1cca6d4bebf2cf3ffefd8f3f1ddef679d7fbf3dffef8732bc7a25cfff1e6d3f0d7960edb31d67feded5b8e7599ae7fa5f3fcd7d694e9776ffeba7e8e34fb967f6dcf980fe9f8c35bff0659cbbc6ccfff03261d8b756a8bff17c8effcd64ee3df18f85f1044fd6ffbfcd68bf26cf37fe50f43108afc2bfbe528c7bcfc8ff118fe3948fc9cfb33ff6b1b477bf4dfbbb2a978fe7148d826d3ff63249c7921d8998c46a99064da9810681269641ead91e288eae39e7074cc38095f4cb73e6e0a7aa4ee3b9c08e5742bd5fb49eade8ec230b0a0e4f36051e51cf4154aa211789033e815cd01cc7215982b98a320fca1d003174de5a032f9a82812a40e0a04cff5da6110a0f29342030aada897a202f32e8031536ba24402701dc12fc9ce0789821c30036671dcc079da431fe86d741291419d90b718923b5ea0441dd09149b17550d10bb6e3e3b5bdd00a5890c233fa7d1303535d261e3715a1508eda7222ea805df0072026038a1001b543c0750542112de3fd530506b264ef8b7aa1191f4fa799a7f405ca0181317425f6f3752dd57b77693ed0ac983ea788979f639ac734ee485dcb10625d15c805b8577a5ef0b892
06-25 03:29:40.934+0200 W/SHealthService( 1373): CpuLock.cpp: CheckAndReset(128) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-25 03:29:40.939+0200 I/WSM     ( 1178): WSM_I [Run, line = 150] Send reply to client.
06-25 03:29:40.939+0200 I/WSM     ( 1178): WSM_D [Run] Send reply =  [len=16492] 01000000700300006533d27d78da8d57c70ec4c86efc95c55e65acb234f24d39e7ac8ba19c4639cbf0bf7b761f0cf8e08379647717293659d5facf3ffe1cca6d4bebf2cf3ffefd8f3f1ddef679d7fbf3dffef8732bc7a25cfff1e6d3f0d7960edb31d67feded5b8e7599ae7fa5f3fcd7d694e9776ffeba7e8e34fb967f6dcf980fe9f8c35bff0659cbbc6ccfff03261d8b756a8bff17c8effcd64ee3df18f85f1044fd6ffbfcd68bf26cf37fe50f43108afc2bfbe528c7bcfc8ff118fe3948fc9cfb33ff6b1b477bf4dfbbb2a978fe7148d826d3ff63249c7921d8998c46a99064da9810681269641ead91e288eae39e7074cc38095f4cb73e6e0a7aa4ee3b9c08e5742bd5fb49eade8ec230b0a0e4f36051e51cf4154aa211789033e815cd01cc7215982b98a320fca1d003174de5a032f9a82812a40e0a04cff5da6110a0f29342030aada897a202f32e8031536ba24402701dc12fc9ce0789821c30036671dcc079da431fe86d741291419d90b718923b5ea0441dd09149b17550d10bb6e3e3b5bdd00a5890c233fa7d1303535d261e3715a1508eda7222ea805df0072026038a1001b543c0750542112de3fd530506b264ef8b7aa1191f4fa799a7f405ca0181317425f6f3752dd57b77693ed0ac983ea788979f639ac734ee485dcb10625d15c805b8577a5ef0b8922c6
06-25 03:29:40.964+0200 W/SHealthService( 1373): CommonSyncController.cpp: CommonSyncStart(281) > [1;35mRelease cpu lock[0;m
06-25 03:29:41.019+0200 I/WSM     ( 1178): WSM_I [Run, line = 118, thread  = 418b7460] Read request from client. 
06-25 03:29:41.019+0200 I/WSM     ( 1178): WSM_I [Run] Request len 406c 
06-25 03:29:41.019+0200 I/WSM     ( 1178): WSM_D [Run] Request data  =  [len=16492] 10f63240800300008be11c5d87442823da49f615783f8d07defea6b5b00bd241d0df8f757a082e39c7b847624d7cef083e78477757bc49b8d8b1849c6bf57708f985806fa94e9ead23afcf9144d137e6e0b37a55bd2a1142600b6e7af496fcfbbfd445a34077de27b11594f1c0f76f75ba677d85c204d6a8a06a5800b93608c12985a75ce0c1f24e7ea20b470a6415f49e9df6cdf053859f2e35c16c271e8331adde0faae7c54796d840aa5270d0d8e69d43c311d554e433e697b9a934255c60490f0c7b3ae9313bed7c21d2f47f042da1ce29d15774df6a7377b82a9299e96b248f2dabd51621fe61836a25de7b25057e4ad82e292d72cb6944b018e8f27ea4eb30e07f59210207ad862289e10cb8f1eed3086beac452b517a1af5818db3e811305d90110812461cb0dcf162cb7d5a8c8b9e6d1be7a69fd63951011aea02bfb52bfc10094362476b64b6201cccd9716c60c6b88515b5a86da4b8d93ec3d8f85d7aa7e780bc5ad53d4778c00144cd5d88bffa02645c88756e8e03693786835b4eb329f5720eb052163956054bf80ac32368a170000000e137e7273bbc7582ca4e3d54b44e2b6b2df90b36a0d39bd489c8b73ea31038ef8e10e48b5a42cd200cbc77ed46c48e05b6bacca7f2395d25a6a288ee88ca3c5000000000000000000000000000000000000000000
06-25 03:29:41.024+0200 I/WSM     ( 1178): WSM_I [Run, line = 150] Send reply to client.
06-25 03:29:41.024+0200 I/WSM     ( 1178): WSM_D [Run] Send reply =  [len=16492] 01000000800300006533d27d87442823da49f615783f8d07defea6b5b00bd241d0df8f757a082e39c7b847624d7cef083e78477757bc49b8d8b1849c6bf57708f985806fa94e9ead23afcf9144d137e6e0b37a55bd2a1142600b6e7af496fcfbbfd445a34077de27b11594f1c0f76f75ba677d85c204d6a8a06a5800b93608c12985a75ce0c1f24e7ea20b470a6415f49e9df6cdf053859f2e35c16c271e8331adde0faae7c54796d840aa5270d0d8e69d43c311d554e433e697b9a934255c60490f0c7b3ae9313bed7c21d2f47f042da1ce29d15774df6a7377b82a9299e96b248f2dabd51621fe61836a25de7b25057e4ad82e292d72cb6944b018e8f27ea4eb30e07f59210207ad862289e10cb8f1eed3086beac452b517a1af5818db3e811305d90110812461cb0dcf162cb7d5a8c8b9e6d1be7a69fd63951011aea02bfb52bfc10094362476b64b6201cccd9716c60c6b88515b5a86da4b8d93ec3d8f85d7aa7e780bc5ad53d4778c00144cd5d88bffa02645c88756e8e03693786835b4eb329f5720eb052163956054bf80ac32368a170000000e137e7273bbc7582ca4e3d54b44e2b6b2df90b36a0d39bd489c8b73ea31038ef8e10e48b5a42cd200cbc77ed46c48e05b6bacca7f2395d25a6a288ee88ca3c5000000000000000000000000000000000000000000000
06-25 03:29:41.124+0200 W/SHealthService( 1373): SAPNotificationCallback.cpp: SAPNotiOnDataIndication(49) > [1;35muwServiceHandle:4, uwChannelId:999, uwPayloadLength: 374[0;m
06-25 03:29:41.124+0200 W/SHealthCommon( 1373): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 0[0;m
06-25 03:29:41.124+0200 W/SHealthService( 1373): SAPMessageDispatcher.cpp: GetHostMessageInfo(274) > [1;40;33mobject format[0;m
06-25 03:29:41.124+0200 W/SHealthCommon( 1373): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (responseMessage)[0;m
06-25 03:29:41.124+0200 W/SHealthCommon( 1373): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (message_type)[0;m
06-25 03:29:41.124+0200 W/SHealthCommon( 1373): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (capability_type)[0;m
06-25 03:29:41.124+0200 W/SHealthCommon( 1373): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_type)[0;m
06-25 03:29:41.124+0200 W/SHealthCommon( 1373): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_feature)[0;m
06-25 03:29:41.124+0200 W/SHealthService( 1373): SAPMessageDispatcher.cpp: Dispatch(200) > [1;40;33mAPP COMMAND MESSAGE!![0;m
06-25 03:29:41.124+0200 W/SHealthService( 1373): AppCmdManager.cpp: OnSAPAppCommand(391) > [1;35mAPP COMMAND MESSAGE RECEIVER: com.samsung.tizengear.app.shealth.social, BODY SIZE[172] [0;m
06-25 03:29:41.124+0200 W/SHealthCommon( 1373): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 0[0;m
06-25 03:29:41.124+0200 W/SHealthService( 1373): CpuLock.cpp: CheckAndReset(125) > [1;40;33mREQUEST POWER LOCK CPU [180000][0;m
06-25 03:29:41.164+0200 W/SHealthCommon( 1373): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (update_time)[0;m
06-25 03:29:41.174+0200 W/SHealthService( 1373): CpuLock.cpp: CheckAndReset(128) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-25 03:29:41.279+0200 W/WRT_PLUGINS/TIZEN(17384): SystemInfoCpu.cpp: fetchLoad(76) > Cannot calculate cpu load, previous value returned
06-25 03:29:41.399+0200 I/WSM     ( 1178): WSM_I [Run, line = 118, thread  = 418b7460] Read request from client. 
06-25 03:29:41.399+0200 I/WSM     ( 1178): WSM_I [Run] Request len 406c 
06-25 03:29:41.399+0200 I/WSM     ( 1178): WSM_D [Run] Request data  =  [len=16492] 10f63240800300008be11c5d3c42f6b9690858508d13dbf759b13c2c1174b333ce8575d483d0774d586d15113093bb87cebab13cd5170a1b9ca0e6c811aacb36c057a41068054d20f60f7ecef2a1b90e48385f0f1e1eb9d42248df9ef42d826d49f1c312199a86208c20879786da8a9acf030355f73f77e7cece6289d41d4f68cfc5506ef61da08d10b6af72c3934915556cc0f04d08b3bbbab6fbbaa50b67ed0f221f0adeca28e5ded1efabc3edabb9cf1d2ee7d518c649f5455d01b156569379e2759776211c2508ee8bf26b644bdd4cc1ba1845e32fc8d2718f4abb9a4250c20af3afcfe57ab583720d52d533cc0547378bdeb9b85b18f9194d2e8a07a68d5739ac85616b13c3c61d281dade846055495a1e24533c0128b894ff7e8ae2f9ce4df77dd349599d3e58254c4b9bb3c89e6c4671e00c8cee7d4d54e8551f579e30c0fbbbdb1b7a0023378508e83615ee1968a56af4de044ca1924f3d8379c1cd3590f1d92152f7a8d28e46faccf22db9cb2ecfaf7ee6589d9879bd562caa54c098b1d1c0cc08a8a8a793e1d7ecfb807e92752dc89ddbe7a6db1eb0b3a5ea3a95f6574727d76923fa2c27dbbd6d36a6818455ec5c43573d44d193a8758470a3bdfeff32431a9155434e1659baf936744ad150522758a3a5de22603180000003aa27a140fb470aa054d72fffe
06-25 03:29:41.404+0200 I/WSM     ( 1178): WSM_I [Run, line = 150] Send reply to client.
06-25 03:29:41.404+0200 I/WSM     ( 1178): WSM_D [Run] Send reply =  [len=16492] 01000000800300006533d27d3c42f6b9690858508d13dbf759b13c2c1174b333ce8575d483d0774d586d15113093bb87cebab13cd5170a1b9ca0e6c811aacb36c057a41068054d20f60f7ecef2a1b90e48385f0f1e1eb9d42248df9ef42d826d49f1c312199a86208c20879786da8a9acf030355f73f77e7cece6289d41d4f68cfc5506ef61da08d10b6af72c3934915556cc0f04d08b3bbbab6fbbaa50b67ed0f221f0adeca28e5ded1efabc3edabb9cf1d2ee7d518c649f5455d01b156569379e2759776211c2508ee8bf26b644bdd4cc1ba1845e32fc8d2718f4abb9a4250c20af3afcfe57ab583720d52d533cc0547378bdeb9b85b18f9194d2e8a07a68d5739ac85616b13c3c61d281dade846055495a1e24533c0128b894ff7e8ae2f9ce4df77dd349599d3e58254c4b9bb3c89e6c4671e00c8cee7d4d54e8551f579e30c0fbbbdb1b7a0023378508e83615ee1968a56af4de044ca1924f3d8379c1cd3590f1d92152f7a8d28e46faccf22db9cb2ecfaf7ee6589d9879bd562caa54c098b1d1c0cc08a8a8a793e1d7ecfb807e92752dc89ddbe7a6db1eb0b3a5ea3a95f6574727d76923fa2c27dbbd6d36a6818455ec5c43573d44d193a8758470a3bdfeff32431a9155434e1659baf936744ad150522758a3a5de22603180000003aa27a140fb470aa054d72fffe5a0
06-25 03:29:41.534+0200 W/SHealthService( 1373): SAPNotificationCallback.cpp: SAPNotiOnDataIndication(49) > [1;35muwServiceHandle:4, uwChannelId:999, uwPayloadLength: 446[0;m
06-25 03:29:41.534+0200 W/SHealthCommon( 1373): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 0[0;m
06-25 03:29:41.534+0200 W/SHealthService( 1373): SAPMessageDispatcher.cpp: GetHostMessageInfo(274) > [1;40;33mobject format[0;m
06-25 03:29:41.534+0200 W/SHealthCommon( 1373): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (responseMessage)[0;m
06-25 03:29:41.534+0200 W/SHealthCommon( 1373): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (message_type)[0;m
06-25 03:29:41.534+0200 W/SHealthCommon( 1373): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (capability_type)[0;m
06-25 03:29:41.534+0200 W/SHealthCommon( 1373): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_type)[0;m
06-25 03:29:41.534+0200 W/SHealthCommon( 1373): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_feature)[0;m
06-25 03:29:41.534+0200 W/SHealthService( 1373): SAPMessageDispatcher.cpp: Dispatch(200) > [1;40;33mAPP COMMAND MESSAGE!![0;m
06-25 03:29:41.534+0200 W/SHealthService( 1373): AppCmdManager.cpp: OnSAPAppCommand(391) > [1;35mAPP COMMAND MESSAGE RECEIVER: com.samsung.tizengear.app.shealth.wearable.syncmanager, BODY SIZE[208] [0;m
06-25 03:29:41.534+0200 W/SHealthCommon( 1373): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 1[0;m
06-25 03:29:41.534+0200 W/SHealthService( 1373): CpuLock.cpp: CheckAndReset(125) > [1;40;33mREQUEST POWER LOCK CPU [180000][0;m
06-25 03:29:41.569+0200 W/SHealthService( 1373): CommonSyncController.cpp: OnAppCommand(379) > [1;40;33mCommon Sync protocol type : 3[0;m
06-25 03:29:41.569+0200 W/SHealthService( 1373): CommonSyncController.cpp: CommonSyncDispather(406) > [1;40;33mHOST_SYNC_MSG [ action : SYNC_DATA, result : SUCCESS,  ][ version : 4.510000, last_sync_time : 1498333126836,  ] [size: 164][0;m
06-25 03:29:41.579+0200 W/SHealthService( 1373): CommonSyncController.cpp: CommonSyncDispather(415) > [1;40;33maction type : SYNC_DATA[0;m
06-25 03:29:41.579+0200 W/SHealthService( 1373): CommonSyncController.cpp: CommonSyncDispather(493) > [1;40;33mresponse : SUCCESS[0;m
06-25 03:29:41.644+0200 W/SHealthCommon( 1373): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
06-25 03:29:41.679+0200 W/SHealthCommon( 1373): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
06-25 03:29:41.679+0200 W/SHealthService( 1373): SAPV45MessageBuilder.cpp: MakeRequestDataRequestMsg(512) > [1;40;33mGEAR_SYNC_MSG [ action : REQUEST_DATA ][ device : Gear S2, device_type : 10032, version : 4.510000, last_sync_time : 1498354181602, reset_time : 1487887200000 ][0;m
06-25 03:29:41.694+0200 W/SHealthCommon( 1373): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
06-25 03:29:41.709+0200 W/SHealthService( 1373): SAP.cpp: SAPClientSend(423) > [1;40;33msend before message length [495][0;m
06-25 03:29:41.734+0200 I/WSM     ( 1178): WSM_I [Run, line = 118, thread  = 418b7460] Read request from client. 
06-25 03:29:41.734+0200 I/WSM     ( 1178): WSM_I [Run] Request len 406c 
06-25 03:29:41.734+0200 I/WSM     ( 1178): WSM_D [Run] Request data  =  [len=16492] 10f63240700300008be11c5d7b20226d65737361676522203a202252455155455354222c202273656e64657222203a2022636f6d2e73616d73756e672e74697a656e676561722e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c2022726563656976657222203a2022636f6d2e73616d73756e672e616e64726f69642e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c202276657273696f6e22203a20352e303039393939393939393939393939382c202264657669636522203a20223130303332222c202273657175656e63655f6e756d22203a2035372c20227479706522203a202244415441222c2022626f647922203a20224834734941414141414141414131324f775171444d4242456632584a5755725557474e765171586e566e735343634675533644476b675242697639656f36564935375a765a6e6133686a6551447132564478524b33337343423667396c4b31547666596a7552546e61314657347068584f59454a4770674348376e686f4e712f3273715732676d6c6754496977532f7078746469685a5447305977484e505a37684f30536d6d33465a2f387072524e32314b3177716c75624c4f4e78776b496537716e66594e4369323767383554794e714e66364b445166
06-25 03:29:41.734+0200 W/SHealthService( 1373): SAP.cpp: SAPClientSend(440) > [1;40;33msend data success !! message length = [495][0;m
06-25 03:29:41.734+0200 W/SHealthService( 1373): SHealthServiceProxy.cpp: OnHostSendSuccess(148) > [1;35mmessage is sent successfully[0;m
06-25 03:29:41.734+0200 W/SHealthService( 1373): SAPMessageDispatcher.cpp: OnHostMessageProgress(464) > [1;35msync progress [0][0;m
06-25 03:29:41.734+0200 W/SHealthService( 1373): CpuLock.cpp: CheckAndReset(128) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-25 03:29:41.739+0200 I/WSM     ( 1178): WSM_I [Run, line = 150] Send reply to client.
06-25 03:29:41.739+0200 I/WSM     ( 1178): WSM_D [Run] Send reply =  [len=16492] 01000000700300006533d27d7b20226d65737361676522203a202252455155455354222c202273656e64657222203a2022636f6d2e73616d73756e672e74697a656e676561722e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c2022726563656976657222203a2022636f6d2e73616d73756e672e616e64726f69642e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c202276657273696f6e22203a20352e303039393939393939393939393939382c202264657669636522203a20223130303332222c202273657175656e63655f6e756d22203a2035372c20227479706522203a202244415441222c2022626f647922203a20224834734941414141414141414131324f775171444d4242456632584a5755725557474e765171586e566e735343634675533644476b675242697639656f36564935375a765a6e6133686a6551447132564478524b33337343423667396c4b31547666596a7552546e61314657347068584f59454a4770674348376e686f4e712f3273715732676d6c6754496977532f7078746469685a5447305977484e505a37684f30536d6d33465a2f387072524e32314b3177716c75624c4f4e78776b496537716e66594e4369323767383554794e714e66364b445166577
06-25 03:29:41.839+0200 I/WSM     ( 1178): WSM_I [Run, line = 118, thread  = 418b7460] Read request from client. 
06-25 03:29:41.839+0200 I/WSM     ( 1178): WSM_I [Run] Request len 406c 
06-25 03:29:41.839+0200 I/WSM     ( 1178): WSM_D [Run] Request data  =  [len=16492] 10f63240800300008be11c5d84f5b1837f707882e29133715a3e9226965df5b2d0635eda56a73f3f4e3bb20f7dc0a1b7d4a60578b974ffb9c5d01332a00c5ac17613ef66aa9f5a9de6ad027584f30f95067183658bd1faa2217de419c1c92d041ead3c24f17e159dd81da433ceffbaa1b9e82dd748e12ddbcc0e8651bf03b21b5be0395f8c57d1bbefb2d40881c6f11dc234a154285e6a5a2f7709f4d4a9a904fa03a969297410fdd222b886689774d44a14b80865e198ef61f086fecdbc1bbc8df69c441788ffbb5001878d41c0d45bb173de93eb4c47c5c5d8aecb117e3980b9884681d883f2986743320e8a6625d3ec89232937af0b53a530c8695abfea8d7b447f198fbd5bab32a0e1c3df6fc584fc032d4c93b6186eb8f54cd9f328fd62df808582d9ef120a9008163ac2046e17a8c43dfcaaf2b1a1ac0755ccefb0aaf9e58cc62f8709da149b6c59c23471de5293d2d9aaca3d3b7fba698e53ad8bce5b8b1af14921f9fbd9fb6132ee370d2cfc2ea59bcc606c4c69c1cb18e5e0c2915823112a6c07d4e4086dae3aa4c78fc95dc8cb4f501866de4377cfa4ffd26fd8813e4169c8ec8638c0466d50339cd1d0affc8fdfd90766358f5e3e8674e35c3ad259c4fd1dcae98c13e4d6aed99e9ee5783634265af89ea63d5cfe65d3b59b19000000f59d0c891fe8c1b302
06-25 03:29:41.844+0200 I/WSM     ( 1178): WSM_I [Run, line = 150] Send reply to client.
06-25 03:29:41.844+0200 I/WSM     ( 1178): WSM_D [Run] Send reply =  [len=16492] 01000000800300006533d27d84f5b1837f707882e29133715a3e9226965df5b2d0635eda56a73f3f4e3bb20f7dc0a1b7d4a60578b974ffb9c5d01332a00c5ac17613ef66aa9f5a9de6ad027584f30f95067183658bd1faa2217de419c1c92d041ead3c24f17e159dd81da433ceffbaa1b9e82dd748e12ddbcc0e8651bf03b21b5be0395f8c57d1bbefb2d40881c6f11dc234a154285e6a5a2f7709f4d4a9a904fa03a969297410fdd222b886689774d44a14b80865e198ef61f086fecdbc1bbc8df69c441788ffbb5001878d41c0d45bb173de93eb4c47c5c5d8aecb117e3980b9884681d883f2986743320e8a6625d3ec89232937af0b53a530c8695abfea8d7b447f198fbd5bab32a0e1c3df6fc584fc032d4c93b6186eb8f54cd9f328fd62df808582d9ef120a9008163ac2046e17a8c43dfcaaf2b1a1ac0755ccefb0aaf9e58cc62f8709da149b6c59c23471de5293d2d9aaca3d3b7fba698e53ad8bce5b8b1af14921f9fbd9fb6132ee370d2cfc2ea59bcc606c4c69c1cb18e5e0c2915823112a6c07d4e4086dae3aa4c78fc95dc8cb4f501866de4377cfa4ffd26fd8813e4169c8ec8638c0466d50339cd1d0affc8fdfd90766358f5e3e8674e35c3ad259c4fd1dcae98c13e4d6aed99e9ee5783634265af89ea63d5cfe65d3b59b19000000f59d0c891fe8c1b30295b
06-25 03:29:41.869+0200 W/SHealthService( 1373): SAPNotificationCallback.cpp: SAPNotiOnDataIndication(49) > [1;35muwServiceHandle:4, uwChannelId:999, uwPayloadLength: 450[0;m
06-25 03:29:41.869+0200 W/SHealthCommon( 1373): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 0[0;m
06-25 03:29:41.869+0200 W/SHealthService( 1373): SAPMessageDispatcher.cpp: GetHostMessageInfo(274) > [1;40;33mobject format[0;m
06-25 03:29:41.869+0200 W/SHealthCommon( 1373): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (responseMessage)[0;m
06-25 03:29:41.869+0200 W/SHealthCommon( 1373): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (message_type)[0;m
06-25 03:29:41.869+0200 W/SHealthCommon( 1373): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (capability_type)[0;m
06-25 03:29:41.869+0200 W/SHealthCommon( 1373): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_type)[0;m
06-25 03:29:41.869+0200 W/SHealthCommon( 1373): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_feature)[0;m
06-25 03:29:41.869+0200 W/SHealthService( 1373): SAPMessageDispatcher.cpp: Dispatch(200) > [1;40;33mAPP COMMAND MESSAGE!![0;m
06-25 03:29:41.869+0200 W/SHealthService( 1373): AppCmdManager.cpp: OnSAPAppCommand(391) > [1;35mAPP COMMAND MESSAGE RECEIVER: com.samsung.tizengear.app.shealth.wearable.syncmanager, BODY SIZE[212] [0;m
06-25 03:29:41.869+0200 W/SHealthCommon( 1373): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 1[0;m
06-25 03:29:41.869+0200 W/SHealthService( 1373): CpuLock.cpp: CheckAndReset(125) > [1;40;33mREQUEST POWER LOCK CPU [180000][0;m
06-25 03:29:41.904+0200 W/SHealthService( 1373): CommonSyncController.cpp: OnAppCommand(379) > [1;40;33mCommon Sync protocol type : 3[0;m
06-25 03:29:41.904+0200 W/SHealthService( 1373): CommonSyncController.cpp: CommonSyncDispather(406) > [1;40;33mHOST_SYNC_MSG [ action : REQUEST_DATA, result : SUCCESS,  ][ version : 4.510000, last_sync_time : 1498333126836,  ] [size: 167][0;m
06-25 03:29:41.929+0200 W/SHealthService( 1373): CommonSyncController.cpp: CommonSyncDispather(415) > [1;40;33maction type : REQUEST_DATA[0;m
06-25 03:29:41.929+0200 W/SHealthService( 1373): CommonSyncController.cpp: CommonSyncDispather(548) > [1;40;33mresponse : SUCCESS[0;m
06-25 03:29:41.929+0200 W/SHealthService( 1373): CpuLock.cpp: CheckAndReset(128) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-25 03:29:41.994+0200 I/AUL     (17384): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
06-25 03:29:42.279+0200 W/WRT_PLUGINS/TIZEN(17384): SystemInfoCpu.cpp: fetchLoad(76) > Cannot calculate cpu load, previous value returned
06-25 03:29:42.329+0200 I/WSM     ( 1178): WSM_I [Run, line = 118, thread  = 418b7460] Read request from client. 
06-25 03:29:42.329+0200 I/WSM     ( 1178): WSM_I [Run] Request len 406c 
06-25 03:29:42.329+0200 I/WSM     ( 1178): WSM_D [Run] Request data  =  [len=16492] 10f63240800300008be11c5d8634f40c823304a04453b16c7f3c5b727a6a7f5df8e2e881f6d53b1674c1151e5438809ffdb21cbe4b497a56cf0107613ba840170d11b2d405dd7dd0bf2e075c1017540e15438787957ac3172f11f6f3a3dc7b8c50239ef835a358e20bf29bc8afbe3bb278b1175e19b3d1cc1dd67fd00f5e0a622729306548d08eea61b8a798a06f64ce94d981fecedf00bb00d007c9fccc8c6926afc627918d7b02d4a2a3abb1d39ad6691f8d7a1c98d489ee38521edb7939575126c588356813d75c927e8dea5df61eefdc54e7d84da71ce7d66f54c66bfc42db37e62d31281dc8323958d72664102ae0d9f230a1fbbaa23588eb72113dfe396568695f5140d5d18a83ce5b6b8b98be95657f15d701146554932371320200e3d6ba9a66293758e440ca3429f4cf3a6ba7aa3d83f3649b00d23cc440fd3e1b7a86346293ce4a28ca047f107e49b768612aedcb790584ac5e1ca89071ebd5b40c4615b0d2ed65498d99c1744b236e3f0912812d025fcac6151d52a18131a5cfc0320a130a7a532cb0f3864cb480e9b90698bbed2fdbf93de4edd32245834ed620717e4780018de88752d7d5ce0a681cb84fc67d1304c5248bd1d36437d67b9b16734594e407070db378f3213086d5a1ba589758f4cc3dce7accafc93ff7d2178922d1cf077dda209dd964a9
06-25 03:29:42.334+0200 I/WSM     ( 1178): WSM_I [Run, line = 150] Send reply to client.
06-25 03:29:42.334+0200 I/WSM     ( 1178): WSM_D [Run] Send reply =  [len=16492] 01000000800300006533d27d8634f40c823304a04453b16c7f3c5b727a6a7f5df8e2e881f6d53b1674c1151e5438809ffdb21cbe4b497a56cf0107613ba840170d11b2d405dd7dd0bf2e075c1017540e15438787957ac3172f11f6f3a3dc7b8c50239ef835a358e20bf29bc8afbe3bb278b1175e19b3d1cc1dd67fd00f5e0a622729306548d08eea61b8a798a06f64ce94d981fecedf00bb00d007c9fccc8c6926afc627918d7b02d4a2a3abb1d39ad6691f8d7a1c98d489ee38521edb7939575126c588356813d75c927e8dea5df61eefdc54e7d84da71ce7d66f54c66bfc42db37e62d31281dc8323958d72664102ae0d9f230a1fbbaa23588eb72113dfe396568695f5140d5d18a83ce5b6b8b98be95657f15d701146554932371320200e3d6ba9a66293758e440ca3429f4cf3a6ba7aa3d83f3649b00d23cc440fd3e1b7a86346293ce4a28ca047f107e49b768612aedcb790584ac5e1ca89071ebd5b40c4615b0d2ed65498d99c1744b236e3f0912812d025fcac6151d52a18131a5cfc0320a130a7a532cb0f3864cb480e9b90698bbed2fdbf93de4edd32245834ed620717e4780018de88752d7d5ce0a681cb84fc67d1304c5248bd1d36437d67b9b16734594e407070db378f3213086d5a1ba589758f4cc3dce7accafc93ff7d2178922d1cf077dda209dd964a9e09
06-25 03:29:42.339+0200 W/SHealthService( 1373): SAPNotificationCallback.cpp: SAPNotiOnDataIndication(49) > [1;35muwServiceHandle:4, uwChannelId:999, uwPayloadLength: 1584[0;m
06-25 03:29:42.344+0200 W/SHealthCommon( 1373): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 0[0;m
06-25 03:29:42.344+0200 W/SHealthService( 1373): SAPMessageDispatcher.cpp: GetHostMessageInfo(274) > [1;40;33mobject format[0;m
06-25 03:29:42.344+0200 W/SHealthCommon( 1373): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (responseMessage)[0;m
06-25 03:29:42.344+0200 W/SHealthCommon( 1373): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (message_type)[0;m
06-25 03:29:42.344+0200 W/SHealthCommon( 1373): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (capability_type)[0;m
06-25 03:29:42.344+0200 W/SHealthCommon( 1373): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_type)[0;m
06-25 03:29:42.344+0200 W/SHealthCommon( 1373): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_feature)[0;m
06-25 03:29:42.344+0200 W/SHealthService( 1373): SAPMessageDispatcher.cpp: Dispatch(200) > [1;40;33mAPP COMMAND MESSAGE!![0;m
06-25 03:29:42.344+0200 W/SHealthService( 1373): AppCmdManager.cpp: OnSAPAppCommand(391) > [1;35mAPP COMMAND MESSAGE RECEIVER: com.samsung.tizengear.app.shealth.wearable.syncmanager, BODY SIZE[1352] [0;m
06-25 03:29:42.344+0200 W/SHealthCommon( 1373): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 1[0;m
06-25 03:29:42.344+0200 W/SHealthService( 1373): CpuLock.cpp: CheckAndReset(125) > [1;40;33mREQUEST POWER LOCK CPU [180000][0;m
06-25 03:29:42.399+0200 W/SHealthService( 1373): CommonSyncController.cpp: OnAppCommand(379) > [1;40;33mCommon Sync protocol type : 3[0;m
06-25 03:29:42.399+0200 W/SHealthService( 1373): CommonSyncController.cpp: CommonSyncDispather(406) > [1;40;33mHOST_SYNC_MSG [ action : SYNC_DATA,  ][ version : 4.510000, start_time : 0x44b4c4c8, end_time : 0x45d05718, last_sync_time : 1498333126836, is_last_chunk : 1,  ] [size: 2206][0;m
06-25 03:29:42.399+0200 W/SHealthCommon( 1373): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (result)[0;m
06-25 03:29:42.409+0200 W/SHealthService( 1373): CommonSyncController.cpp: CommonSyncDispather(415) > [1;40;33maction type : SYNC_DATA[0;m
06-25 03:29:42.424+0200 W/SHealthCommon( 1373): SystemUtil.cpp: IsShowCaseBinary(1220) > [1;35misShowCaseBinary : 0[0;m
06-25 03:29:42.514+0200 W/SHealthCommon( 1373): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
06-25 03:29:42.549+0200 W/SHealthCommon( 1373): SystemUtil.cpp: GetDeviceNickName(613) > [1;40;33mDevice Nick Name [Orbis][0;m
06-25 03:29:42.564+0200 W/SHealthService( 1373): SAPV45MessageBuilder.cpp: MakeCommonSyncResponseMsg(464) > [1;40;33mGEAR_SYNC_MSG [ action : SYNC_DATA , result : SUCCESS ][ device : Gear S2, device_type : 10032, version : 4.510000, last_sync_time : 1498354181602, reset_time : 1487887200000 ][0;m
06-25 03:29:42.564+0200 W/SHealthService( 1373): SAP.cpp: SAPClientSend(423) > [1;40;33msend before message length [512][0;m
06-25 03:29:42.589+0200 W/SHealthService( 1373): SAP.cpp: SAPClientSend(440) > [1;40;33msend data success !! message length = [512][0;m
06-25 03:29:42.589+0200 W/SHealthService( 1373): SHealthServiceProxy.cpp: OnHostSendSuccess(148) > [1;35mmessage is sent successfully[0;m
06-25 03:29:42.589+0200 W/SHealthService( 1373): SAPMessageDispatcher.cpp: OnHostMessageProgress(464) > [1;35msync progress [0][0;m
06-25 03:29:42.589+0200 I/WSM     ( 1178): WSM_I [Run, line = 118, thread  = 418b7460] Read request from client. 
06-25 03:29:42.589+0200 I/WSM     ( 1178): WSM_I [Run] Request len 406c 
06-25 03:29:42.589+0200 I/WSM     ( 1178): WSM_D [Run] Request data  =  [len=16492] 10f63240700300008be11c5d7b20226d65737361676522203a2022524553504f4e5345222c202273656e64657222203a2022636f6d2e73616d73756e672e74697a656e676561722e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c2022726563656976657222203a2022636f6d2e73616d73756e672e616e64726f69642e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c202276657273696f6e22203a20342e353039393939393939393939393939382c202264657669636522203a20223130303332222c202273657175656e63655f6e756d22203a2033342c20227479706522203a202244415441222c2022626f647922203a20224834734941414141414141414131324f7a5171444d4243455832584a5755714d576d4e766b706265656b6c374b434968324c51452f436b6d46615434376a5847673352752b38334f376854774264516f592b524c4364302b4f7751484b4279556c645664363062453778636d6a766b315277476758706c506254322f4d586269484d45454a557942537a33556f4b752f5335347469624f535058446937717962646e7776566f687852475938714e3673662b4e6467724f74364f7a58306c686878725953566a632b4757633053754b51686e744d664546
06-25 03:29:42.594+0200 I/WSM     ( 1178): WSM_I [Run, line = 150] Send reply to client.
06-25 03:29:42.594+0200 I/WSM     ( 1178): WSM_D [Run] Send reply =  [len=16492] 01000000700300006533d27d7b20226d65737361676522203a2022524553504f4e5345222c202273656e64657222203a2022636f6d2e73616d73756e672e74697a656e676561722e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c2022726563656976657222203a2022636f6d2e73616d73756e672e616e64726f69642e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c202276657273696f6e22203a20342e353039393939393939393939393939382c202264657669636522203a20223130303332222c202273657175656e63655f6e756d22203a2033342c20227479706522203a202244415441222c2022626f647922203a20224834734941414141414141414131324f7a5171444d4243455832584a5755714d576d4e766b706265656b6c374b434968324c51452f436b6d46615434376a5847673352752b38334f376854774264516f592b524c4364302b4f7751484b4279556c645664363062453778636d6a766b315277476758706c506254322f4d586269484d45454a557942537a33556f4b752f5335347469624f535058446937717962646e7776566f687852475938714e3673662b4e6467724f74364f7a58306c686878725953566a632b4757633053754b51686e744d6645466c4
06-25 03:29:42.654+0200 W/SHealthService( 1373): SHealthSapSyncManager.cpp: NotifySAPSyncSuccess(152) > [1;35msync is completed[0;m
06-25 03:29:42.654+0200 W/SHealthCommon( 1373): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: sync_done, pendingClientInfoList.size(): 0[0;m
06-25 03:29:42.654+0200 W/SHealthService( 1373): CpuLock.cpp: CheckAndReset(128) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-25 03:29:42.694+0200 W/SHealthCommon( 1373): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: SocialDataUpdatedServiceMessage, pendingClientInfoList.size(): 0[0;m
06-25 03:29:42.734+0200 W/SHealthCommon( 1373): SocialStorage.cpp: GetEnabledChallengeTid(651) > [1;40;33mTID: 0 , Status : 0[0;m
06-25 03:29:42.734+0200 W/SHealthCommon( 1373): SocialStorage.cpp: GetTogetherEnabled(695) > [1;40;33mServiceType: 1 , Status : 102[0;m
06-25 03:29:42.734+0200 W/SHealthCommon( 1373): SocialStorage.cpp: GetTogetherEnabled(703) > [1;40;33mTogether Type[1] is enabled[0;m
06-25 03:29:42.734+0200 W/SHealthCommon( 1373): SocialStorage.cpp: GetTogetherEnabled(695) > [1;40;33mServiceType: 1 , Status : 102[0;m
06-25 03:29:42.734+0200 W/SHealthCommon( 1373): SocialStorage.cpp: GetTogetherEnabled(703) > [1;40;33mTogether Type[1] is enabled[0;m
06-25 03:29:42.734+0200 W/SHealthCommon( 1373): SocialStorage.cpp: GetTogetherEnabled(695) > [1;40;33mServiceType: 2 , Status : 0[0;m
06-25 03:29:42.734+0200 W/SHealthCommon( 1373): SocialStorage.cpp: GetTogetherEnabled(700) > [1;40;33mTogether Type[2] is disabled[0;m
06-25 03:29:42.734+0200 W/SHealthService( 1373): SocialController.cpp: OnSocialDBDataChanged(770) > [1;40;33mPreferenceVersion[1001], togetherLeadOrChal[1], Stat[102], EnabledSocial[102], isEnabledLead[1], EnabledLead[102], isEnabledChal[0], EnabledChal[0][0;m
06-25 03:29:42.769+0200 W/SHealthCommon( 1373): SocialStorage.cpp: GetTogetherEnabled(695) > [1;40;33mServiceType: 2 , Status : 0[0;m
06-25 03:29:42.769+0200 W/SHealthCommon( 1373): SocialStorage.cpp: GetTogetherEnabled(700) > [1;40;33mTogether Type[2] is disabled[0;m
06-25 03:29:42.769+0200 W/SHealthService( 1373): SocialController.cpp: OnSocialDBDataChanged(839) > [1;40;33mChallenge is disabled by mobile![0;m
06-25 03:29:42.789+0200 I/HealthDataService(  986): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
06-25 03:29:42.799+0200 W/CRASH_MANAGER(14151): worker.c: worker_job(1205) > 111418973636f149835417
