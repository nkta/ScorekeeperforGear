S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.2
Build-Number: Tizen-2.3.2_Wearable-Emulator_20170403.0854
Build-Date: 2017.04.03 08:54:58

Crash Information
Process Name: scorekeeperforgear
PID: 2820
Date: 2017-06-19 04:03:09+0900
Executable File Path: /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x46

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb41a3554, esi = 0x00000000
ebp = 0xbfbc5528, esp = 0xbfbc48d4
eax = 0xffffffff, ebx = 0xb75dcff4
ecx = 0x00000000, edx = 0xb75de430
eip = 0xb74bdec2

Memory Information
MemTotal:      123 KB
MemFree:        59 KB
Buffers:         2 KB
Cached:     135208 KB
VmPeak:      63188 KB
VmSize:      63188 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        6924 KB
VmRSS:        6924 KB
VmData:       2168 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       32636 KB
VmPTE:          52 KB
VmSwap:          0 KB

Maps Information
b3b64000 b3b67000 r-xp /usr/lib/libdri2.so.0.0.0
b3b68000 b3b73000 r-xp /usr/lib/libdrm.so.2.4.0
b3b74000 b3b7d000 r-xp /usr/lib/libtbm.so.1.0.0
b3b7e000 b3b85000 r-xp /usr/lib/libcapi-media-tool.so.0.1.1
b3b86000 b3b8f000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3b90000 b3b97000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3b98000 b3ba0000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3ba1000 b3ba5000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.3
b3ba6000 b3bc3000 r-xp /usr/lib/libtts.so
b3bc4000 b3bda000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
b3bdb000 b3d1f000 r-xp /usr/lib/libcairo.so.2.11200.14
b3d23000 b3d3b000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3d3c000 b3d42000 r-xp /usr/lib/libctx-client.so.0.8.3
b3d43000 b3d4d000 r-xp /usr/lib/libctx-shared.so.0.8.3
b3d4e000 b3d54000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3d55000 b3d67000 r-xp /usr/lib/libdeviced.so.0.1.0
b3d68000 b3d8b000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3d8c000 b3d9c000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3d9d000 b3dae000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b3db0000 b3db7000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b3db8000 b3dc3000 r-xp /lib/libnss_files-2.13.so
b3fc5000 b3fec000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b3fed000 b4012000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4013000 b4134000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4144000 b4179000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b417b000 b417e000 r-xp /usr/lib/libiniparser.so.0
b4180000 b418a000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0
b418b000 b4194000 r-xp /usr/lib/libappsvc.so.0.1.0
b4195000 b4198000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4199000 b41a6000 r-xp /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
b41a8000 b41ae000 r-xp /usr/lib/libogg.so.0.7.1
b41af000 b41da000 r-xp /usr/lib/libvorbis.so.0.4.3
b41db000 b42c6000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42d4000 b42d6000 r-xp /usr/lib/libXau.so.6.0.0
b42d7000 b4330000 r-xp /usr/lib/libssl.so.1.0.0
b4335000 b4366000 r-xp /usr/lib/libidn.so.11.5.44
b4367000 b4377000 r-xp /usr/lib/libcares.so.2.1.0
b4378000 b43e1000 r-xp /usr/lib/libsndfile.so.1.0.25
b43e7000 b43f3000 r-xp /usr/lib/libsensord-shared.so
b43f4000 b441a000 r-xp /lib/libexpat.so.1.5.2
b441c000 b4443000 r-xp /usr/lib/libpng12.so.0.50.0
b4444000 b4464000 r-xp /usr/lib/libxcb.so.1.1.0
b4465000 b44d4000 r-xp /usr/lib/libcurl.so.4.3.0
b44d6000 b44e1000 r-xp /usr/lib/libethumb.so.1.7.99
b5d5e000 b5e36000 r-xp /usr/lib/libstdc++.so.6.0.16
b5e42000 b5e45000 r-xp /usr/lib/libctxdata.so.0.0.0
b5e46000 b5e5c000 r-xp /usr/lib/libremix.so.0.0.0
b5e5d000 b5e5f000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5e60000 b5e8c000 r-xp /usr/lib/liblua-5.1.so
b5e8d000 b5e97000 r-xp /usr/lib/libembryo.so.1.7.99
b5e98000 b5ede000 r-xp /usr/lib/libjpeg.so.8.0.2
b5eef000 b5f1e000 r-xp /usr/lib/libsensor.so.1.9.0
b5f1f000 b5fa1000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5fa6000 b5fda000 r-xp /usr/lib/libfontconfig.so.1.5.0
b5fdc000 b6037000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6039000 b604f000 r-xp /usr/lib/libfribidi.so.0.3.1
b6050000 b60dc000 r-xp /usr/lib/libfreetype.so.6.11.3
b60e0000 b60e3000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b60e4000 b60ea000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b60eb000 b60f1000 r-xp /usr/lib/libecore_fb.so.1.7.99
b60f3000 b6104000 r-xp /usr/lib/libXext.so.6.4.0
b6105000 b6239000 r-xp /usr/lib/libX11.so.6.3.0
b623d000 b6242000 r-xp /usr/lib/libXtst.so.6.1.0
b6243000 b624b000 r-xp /usr/lib/libXrender.so.1.3.0
b624c000 b6255000 r-xp /usr/lib/libXrandr.so.2.2.0
b6256000 b6258000 r-xp /usr/lib/libXinerama.so.1.0.0
b6259000 b6267000 r-xp /usr/lib/libXi.so.6.1.0
b6268000 b626c000 r-xp /usr/lib/libXfixes.so.3.1.0
b626d000 b626f000 r-xp /usr/lib/libXgesture.so.7.0.0
b6270000 b6272000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6273000 b6275000 r-xp /usr/lib/libXdamage.so.1.1.0
b6276000 b627f000 r-xp /usr/lib/libXcursor.so.1.0.2
b6280000 b62ab000 r-xp /usr/lib/libecore_con.so.1.7.99
b62ad000 b62b5000 r-xp /usr/lib/libecore_imf.so.1.7.99
b62b6000 b62c1000 r-xp /usr/lib/libethumb_client.so.1.7.99
b62c2000 b62c8000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b62c9000 b62ea000 r-xp /usr/lib/libefreet.so.1.7.99
b62ec000 b62f8000 r-xp /usr/lib/libedbus.so.1.7.99
b62f9000 b6488000 r-xp /usr/lib/libicuuc.so.57.1
b6497000 b6713000 r-xp /usr/lib/libicui18n.so.57.1
b671c000 b67ba000 r-xp /usr/lib/libedje.so.1.7.99
b67bc000 b67cd000 r-xp /usr/lib/libecore_input.so.1.7.99
b67ce000 b67d5000 r-xp /usr/lib/libecore_file.so.1.7.99
b67d6000 b67fc000 r-xp /usr/lib/libeet.so.1.7.99
b6805000 b692f000 r-xp /usr/lib/libevas.so.1.7.99
b694d000 b6981000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6983000 b69c7000 r-xp /usr/lib/libecore_x.so.1.7.99
b69c9000 b6bc4000 r-xp /usr/lib/libelementary.so.1.7.99
b6bd3000 b6bd5000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b6bd6000 b6bdc000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6bdd000 b6be1000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6be6000 b6be7000 r-xp /usr/lib/libjournal.so.0.1.0
b6be8000 b6d30000 r-xp /usr/lib/libxml2.so.2.7.8
b6d36000 b6d49000 r-xp /lib/libresolv-2.13.so
b6d4d000 b6d6a000 r-xp /lib/libz.so.1.2.5
b6d6b000 b6d6e000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6d70000 b6d75000 r-xp /usr/lib/libffi.so.5.0.10
b6d76000 b6d77000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6d78000 b6d7c000 r-xp /lib/libattr.so.1.1.0
b6d7d000 b6f90000 r-xp /usr/lib/libcrypto.so.1.0.0
b6fab000 b6fcc000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6fce000 b6ff6000 r-xp /lib/libm-2.13.so
b6ff8000 b7053000 r-xp /usr/lib/libeina.so.1.7.99
b7055000 b7060000 r-xp /usr/lib/libvconf.so.0.2.45
b7061000 b7064000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b7065000 b70b3000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b70b5000 b7216000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b721a000 b7221000 r-xp /lib/librt-2.13.so
b7223000 b722a000 r-xp /usr/lib/libcapi-base-common.so.0.1.10
b722c000 b7246000 r-xp /lib/libgcc_s-4.6.4.so.1
b7247000 b724f000 r-xp /lib/libcrypt-2.13.so
b7279000 b727d000 r-xp /lib/libcap.so.2.21
b727e000 b7280000 r-xp /usr/lib/libiri.so
b7281000 b72ad000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b72ae000 b72ce000 r-xp /usr/lib/libecore.so.1.7.99
b72dd000 b72e6000 r-xp /usr/lib/libxdgmime.so.1.1.0
b72e7000 b740a000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b740c000 b741f000 r-xp /usr/lib/libail.so.0.1.0
b7420000 b7445000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b7446000 b7450000 r-xp /lib/libunwind.so.8.0.1
b745a000 b75da000 r-xp /lib/libc-2.13.so
b75e1000 b762b000 r-xp /usr/lib/libdbus-1.so.3.7.2
b762d000 b7632000 r-xp /usr/lib/libbundle.so.0.1.22
b7633000 b7636000 r-xp /lib/libdl-2.13.so
b7638000 b764f000 r-xp /lib/libpthread-2.13.so
b7653000 b7656000 r-xp /usr/lib/libdlog.so.0.0.0
b7657000 b7659000 r-xp /usr/lib/libttrace.so.1.1
b765a000 b765f000 r-xp /usr/lib/libsmack.so.1.0.0
b7660000 b7708000 r-xp /usr/lib/libsqlite3.so.0.8.6
b770b000 b7725000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7726000 b7736000 r-xp /usr/lib/libaul.so.0.1.0
b7739000 b773f000 r-xp /usr/lib/libappcore-common.so.1.1
b7740000 b7745000 r-xp /usr/lib/libappcore-efl.so.1.1
b7747000 b774c000 r-xp /usr/lib/libsys-assert.so
b774f000 b7750000 r-xp [vdso]
b7750000 b776e000 r-xp /lib/ld-2.13.so
b7770000 b7777000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:2820)
Call Stack Count: 2
 0: fclose + 0x22 (0xb74bdec2) [/lib/libc.so.6] + 0x63ec2
 1: __libc_start_main + 0xf3 (0xb74731a3) [/lib/libc.so.6] + 0x191a3
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
rtinfo(507) > Id:Count = 12 1
06-19 04:03:06.979+0900 E/PKGMGR_CERT( 2760): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 13 1
06-19 04:03:06.979+0900 E/PKGMGR_CERT( 2760): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 14 1
06-19 04:03:06.979+0900 E/PKGMGR_CERT( 2760): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 15 1
06-19 04:03:06.979+0900 E/PKGMGR_CERT( 2760): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 16 1
06-19 04:03:06.979+0900 D/PKGMGR  ( 2538): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575 / coretpk / org.example.scorekeeperforgear / install_percent / 60
06-19 04:03:06.979+0900 D/PKGMGR  ( 2538): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[60]
06-19 04:03:06.979+0900 D/PKGMGR  ( 2538): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:06.979+0900 D/PKGMGR  ( 2538): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:06.979+0900 E/PKGMGR_CERT( 2760): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 17 1
06-19 04:03:06.989+0900 D/PKGMGR  ( 2424): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575 / coretpk / org.example.scorekeeperforgear / install_percent / 60
06-19 04:03:06.989+0900 D/PKGMGR  ( 2424): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[60]
06-19 04:03:06.989+0900 D/PKGMGR  ( 2424): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:06.989+0900 D/PKGMGR  ( 2424): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:06.989+0900 D/PKGMGR  ( 2425): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575 / coretpk / org.example.scorekeeperforgear / install_percent / 60
06-19 04:03:06.989+0900 D/PKGMGR  ( 2425): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[60]
06-19 04:03:06.989+0900 D/DATA_PROVIDER_MASTER( 2425): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.scorekeeperforgear] 60
06-19 04:03:06.989+0900 D/PKGMGR  ( 2425): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:06.989+0900 D/PKGMGR  ( 2425): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:06.989+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575 / coretpk / org.example.scorekeeperforgear / install_percent / 60
06-19 04:03:06.989+0900 D/PKGMGR  ( 2385): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[60]
06-19 04:03:06.989+0900 D/ADD_VIEWER( 2385): add-viewer_pkgmgr.c: progress_cb(385) > [SECURE_LOG] [org.example.scorekeeperforgear] 60
06-19 04:03:06.989+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:06.989+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:06.989+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575 / coretpk / org.example.scorekeeperforgear / install_percent / 60
06-19 04:03:06.989+0900 D/PKGMGR  ( 2385): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[60]
06-19 04:03:06.989+0900 D/W_HOME  ( 2385): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.scorekeeperforgear key:install_percent val:60
06-19 04:03:06.989+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:06.989+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:06.989+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575 / coretpk / org.example.scorekeeperforgear / install_percent / 60
06-19 04:03:06.989+0900 D/PKGMGR  ( 2385): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[60]
06-19 04:03:06.989+0900 D/APPS    ( 2385): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [install_percent:60] for org.example.scorekeeperforgear
06-19 04:03:06.989+0900 D/APPS    ( 2385): pkgmgr.c: _install_percent(469) >  package(org.example.scorekeeperforgear) with 60
06-19 04:03:06.989+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:06.989+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:06.989+0900 D/PKGMGR  ( 2386): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575 / coretpk / org.example.scorekeeperforgear / install_percent / 60
06-19 04:03:06.989+0900 D/PKGMGR  ( 2386): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[60]
06-19 04:03:06.989+0900 D/PKGMGR  ( 2386): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:06.989+0900 D/PKGMGR  ( 2386): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:06.989+0900 E/PKGMGR_CERT( 2760): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(587) > Transaction Commit and End
06-19 04:03:06.989+0900 E/rpm-installer( 2760): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1234) > skip! empty dirpath=[/usr/apps/org.example.scorekeeperforgear/lib]
06-19 04:03:06.989+0900 E/rpm-installer( 2760): coretpk-installer.c: _coretpk_installer_make_directory(1601) > mkdir failed. appdir=[/usr/apps/org.example.scorekeeperforgear/shared], errno=[2][No such file or directory]
06-19 04:03:06.989+0900 E/rpm-installer( 2760): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1234) > skip! empty dirpath=[/usr/apps/org.example.scorekeeperforgear/shared]
06-19 04:03:06.989+0900 E/rpm-installer( 2760): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1234) > skip! empty dirpath=[/usr/apps/org.example.scorekeeperforgear/shared/res]
06-19 04:03:06.989+0900 E/rpm-installer( 2760): coretpk-installer.c: _coretpk_installer_apply_file_policy(1219) > skip! empty filepath=[/usr/apps/org.example.scorekeeperforgear/tizen-manifest.xml]
06-19 04:03:06.989+0900 E/rpm-installer( 2760): coretpk-installer.c: _coretpk_installer_apply_file_policy(1219) > skip! empty filepath=[/usr/apps/org.example.scorekeeperforgear/author-signature.xml]
06-19 04:03:06.989+0900 E/rpm-installer( 2760): coretpk-installer.c: _coretpk_installer_apply_file_policy(1219) > skip! empty filepath=[/usr/apps/org.example.scorekeeperforgear/signature1.xml]
06-19 04:03:06.989+0900 E/rpm-installer( 2760): coretpk-installer.c: _coretpk_installer_apply_file_policy(1219) > skip! empty filepath=[/usr/share/packages/org.example.scorekeeperforgear.xml]
06-19 04:03:06.989+0900 D/rpm-installer( 2760): coretpk-installer.c: _coretpk_installer_make_directory_for_ext(1405) > Exist shared/data folder (path:[/opt/usr/apps/org.example.scorekeeperforgear/shared/data])
06-19 04:03:06.999+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_register_package(64) > [smack] app_install(org.example.scorekeeperforgear), result=[0]
06-19 04:03:06.999+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/usr/apps/org.example.scorekeeperforgear, 5, _), result=[0]
06-19 04:03:06.999+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/usr/apps/org.example.scorekeeperforgear/shared, 5, _), result=[0]
06-19 04:03:06.999+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/usr/apps/org.example.scorekeeperforgear/shared/res, 5, _), result=[0]
06-19 04:03:07.009+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/usr/apps/org.example.scorekeeperforgear/shared/data, 2), result=[0]
06-19 04:03:07.009+0900 D/rpm-installer( 2760): coretpk-installer.c: _coretpk_installer_get_group_id(1881) > encoding done, len=[28]
06-19 04:03:07.009+0900 D/rpm-installer( 2760): coretpk-installer.c: _coretpk_installer_apply_smack(1989) > groupid = [YE519RlTq5KnqeX1161u+Id8Hi8=] for shared/trusted.
06-19 04:03:07.019+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/usr/apps/org.example.scorekeeperforgear/shared/trusted, 1, YE519RlTq5KnqeX1161u+Id8Hi8=), result=[0]
06-19 04:03:07.019+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/usr/apps/org.example.scorekeeperforgear/bin, 0, org.example.scorekeeperforgear), result=[0]
06-19 04:03:07.019+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/usr/apps/org.example.scorekeeperforgear/data, 0, org.example.scorekeeperforgear), result=[0]
06-19 04:03:07.019+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/usr/apps/org.example.scorekeeperforgear/res, 0, org.example.scorekeeperforgear), result=[0]
06-19 04:03:07.019+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/usr/apps/org.example.scorekeeperforgear/cache, 0, org.example.scorekeeperforgear), result=[0]
06-19 04:03:07.019+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/usr/apps/org.example.scorekeeperforgear/tizen-manifest.xml, 0, org.example.scorekeeperforgear), result=[0]
06-19 04:03:07.019+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/usr/apps/org.example.scorekeeperforgear/author-signature.xml, 0, org.example.scorekeeperforgear), result=[0]
06-19 04:03:07.019+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/usr/apps/org.example.scorekeeperforgear/signature1.xml, 0, org.example.scorekeeperforgear), result=[0]
06-19 04:03:07.019+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/share/packages/org.example.scorekeeperforgear.xml, 0, org.example.scorekeeperforgear), result=[0]
06-19 04:03:07.019+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/storage/sdcard/apps/org.example.scorekeeperforgear, 5, _), result=[0]
06-19 04:03:07.019+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/storage/sdcard/apps/org.example.scorekeeperforgear/data, 0, org.example.scorekeeperforgear), result=[0]
06-19 04:03:07.019+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/storage/sdcard/apps/org.example.scorekeeperforgear/cache, 0, org.example.scorekeeperforgear), result=[0]
06-19 04:03:07.019+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/storage/sdcard/apps/org.example.scorekeeperforgear/shared, 5, _), result=[0]
06-19 04:03:07.029+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.scorekeeperforgear, /opt/storage/sdcard/apps/org.example.scorekeeperforgear/shared/data, 2), result=[0]
06-19 04:03:07.039+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_set_package_version(74) > [smack] app[org.example.scorekeeperforgear] version set to [2.3.2] result=[0]
06-19 04:03:07.039+0900 D/rpm-installer( 2760): coretpk-installer.c: _coretpk_installer_package_install(2345) > api-version fot privilege has done successfully.
06-19 04:03:07.039+0900 D/rpm-installer( 2760): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.scorekeeperforgear], privilege = [http://tizen.org/privilege/display]
06-19 04:03:07.039+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
06-19 04:03:07.039+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.scorekeeperforgear, 7), result=[0]
06-19 04:03:07.049+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
06-19 04:03:07.049+0900 D/rpm-installer( 2760): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.scorekeeperforgear, 7) succeed.
06-19 04:03:07.049+0900 D/rpm-installer( 2760): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.scorekeeperforgear], privilege = [http://tizen.org/privilege/haptic]
06-19 04:03:07.049+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
06-19 04:03:07.049+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.scorekeeperforgear, 7), result=[0]
06-19 04:03:07.059+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
06-19 04:03:07.059+0900 D/rpm-installer( 2760): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.scorekeeperforgear, 7) succeed.
06-19 04:03:07.059+0900 D/rpm-installer( 2760): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.scorekeeperforgear], privilege = [http://tizen.org/privilege/healthinfo]
06-19 04:03:07.059+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
06-19 04:03:07.059+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.scorekeeperforgear, 7), result=[0]
06-19 04:03:07.069+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
06-19 04:03:07.069+0900 D/rpm-installer( 2760): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.scorekeeperforgear, 7) succeed.
06-19 04:03:07.069+0900 D/rpm-installer( 2760): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.scorekeeperforgear], privilege = [http://tizen.org/privilege/mediastorage]
06-19 04:03:07.069+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
06-19 04:03:07.069+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.scorekeeperforgear, 7), result=[0]
06-19 04:03:07.079+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
06-19 04:03:07.079+0900 D/rpm-installer( 2760): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.scorekeeperforgear, 7) succeed.
06-19 04:03:07.079+0900 D/rpm-installer( 2760): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.scorekeeperforgear], privilege = [http://tizen.org/privilege/power]
06-19 04:03:07.079+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
06-19 04:03:07.079+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.scorekeeperforgear, 7), result=[0]
06-19 04:03:07.089+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
06-19 04:03:07.089+0900 D/rpm-installer( 2760): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.scorekeeperforgear, 7) succeed.
06-19 04:03:07.089+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
06-19 04:03:07.089+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.scorekeeperforgear, 7), result=[0]
06-19 04:03:07.099+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
06-19 04:03:07.099+0900 D/rpm-installer( 2760): coretpk-installer.c: _coretpk_installer_package_install(2355) > permission applying done successfully.
06-19 04:03:07.099+0900 D/PRIVILEGE_MANAGER( 2760): privilege_manager.c: privilege_manager_verify_privilege(160) > privilege_manager_verify_privilege called
06-19 04:03:07.099+0900 D/PRIVILEGE_MANAGER( 2760): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/display
06-19 04:03:07.099+0900 D/PRIVILEGE_MANAGER( 2760): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
06-19 04:03:07.099+0900 D/PRIVILEGE_MANAGER( 2760): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
06-19 04:03:07.099+0900 D/PRIVILEGE_MANAGER( 2760): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
06-19 04:03:07.099+0900 D/PRIVILEGE_MANAGER( 2760): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
06-19 04:03:07.099+0900 D/PRIVILEGE_MANAGER( 2760): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/haptic
06-19 04:03:07.099+0900 D/PRIVILEGE_MANAGER( 2760): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
06-19 04:03:07.099+0900 D/PRIVILEGE_MANAGER( 2760): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
06-19 04:03:07.099+0900 D/PRIVILEGE_MANAGER( 2760): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
06-19 04:03:07.099+0900 D/PRIVILEGE_MANAGER( 2760): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
06-19 04:03:07.099+0900 D/PRIVILEGE_MANAGER( 2760): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/healthinfo
06-19 04:03:07.099+0900 D/PRIVILEGE_MANAGER( 2760): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
06-19 04:03:07.099+0900 D/PRIVILEGE_MANAGER( 2760): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
06-19 04:03:07.099+0900 D/PRIVILEGE_MANAGER( 2760): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
06-19 04:03:07.099+0900 D/PRIVILEGE_MANAGER( 2760): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
06-19 04:03:07.099+0900 D/PRIVILEGE_MANAGER( 2760): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/mediastorage
06-19 04:03:07.099+0900 D/PRIVILEGE_MANAGER( 2760): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
06-19 04:03:07.099+0900 D/PRIVILEGE_MANAGER( 2760): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
06-19 04:03:07.099+0900 D/PRIVILEGE_MANAGER( 2760): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
06-19 04:03:07.099+0900 D/PRIVILEGE_MANAGER( 2760): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
06-19 04:03:07.099+0900 D/PRIVILEGE_MANAGER( 2760): privilege_manager.c: privilege_manager_verify_privilege(287) > Checking privilege = http://tizen.org/privilege/power
06-19 04:03:07.099+0900 D/PRIVILEGE_MANAGER( 2760): privilege_manager.c: __privilege_manager_check_privilege_list(38) > Matched privilege name exist
06-19 04:03:07.099+0900 D/PRIVILEGE_MANAGER( 2760): privilege_manager.c: __privilege_manager_check_privilege_list(39) > Check api version
06-19 04:03:07.099+0900 D/PRIVILEGE_MANAGER( 2760): privilege_manager.c: privilege_manager_verify_privilege(335) > visibility = 64
06-19 04:03:07.099+0900 D/PRIVILEGE_MANAGER( 2760): privilege_manager.c: privilege_manager_verify_privilege(336) > privilege level = 0
06-19 04:03:07.099+0900 D/rpm-installer( 2760): coretpk-installer.c: _coretpk_installer_verify_privilege_list(752) > privilege_manager_verify_privilege_list(PRVMGR_PACKAGE_TYPE_CORE) is ok.
06-19 04:03:07.099+0900 D/rpm-installer( 2760): coretpk-installer.c: _coretpk_installer_package_install(2363) > _coretpk_installer_verify_privilege_list done.
06-19 04:03:07.099+0900 D/rpm-installer( 2760): rpm-vconf-intf.c: _ri_broadcast_status_notification(199) > pkgid=[org.example.scorekeeperforgear], key=[install_percent], val=[100]
06-19 04:03:07.099+0900 D/rpm-installer( 2760): coretpk-installer.c: _coretpk_installer_package_install(2385) > install status is [2].
06-19 04:03:07.099+0900 D/rpm-installer( 2760): coretpk-installer.c: __post_install_for_mmc(379) > Installed storage is internal.
06-19 04:03:07.099+0900 D/rpm-installer( 2760): coretpk-installer.c: _coretpk_installer_package_install(2397) > _coretpk_installer_package_install is done.
06-19 04:03:07.099+0900 D/rpm-installer( 2760): rpm-vconf-intf.c: _ri_broadcast_status_notification(207) > pkgid=[org.example.scorekeeperforgear], key=[end], val=[ok]
06-19 04:03:07.099+0900 D/rpm-installer( 2760): coretpk-installer.c: _coretpk_installer_prepare_package_install_with_debug(2964) > success
06-19 04:03:07.099+0900 D/PKGMGR  ( 2538): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575 / coretpk / org.example.scorekeeperforgear / install_percent / 100
06-19 04:03:07.099+0900 D/PKGMGR  ( 2538): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[100]
06-19 04:03:07.099+0900 D/PKGMGR  ( 2538): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:07.099+0900 D/PKGMGR  ( 2538): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:07.099+0900 D/PKGMGR  ( 2425): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575 / coretpk / org.example.scorekeeperforgear / install_percent / 100
06-19 04:03:07.099+0900 D/PKGMGR  ( 2425): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[100]
06-19 04:03:07.099+0900 D/DATA_PROVIDER_MASTER( 2425): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.scorekeeperforgear] 100
06-19 04:03:07.099+0900 D/PKGMGR  ( 2425): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:07.099+0900 D/PKGMGR  ( 2425): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:07.099+0900 D/PKGMGR  ( 2424): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575 / coretpk / org.example.scorekeeperforgear / install_percent / 100
06-19 04:03:07.099+0900 D/PKGMGR  ( 2424): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[100]
06-19 04:03:07.099+0900 D/PKGMGR  ( 2424): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:07.099+0900 D/PKGMGR  ( 2424): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:07.099+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575 / coretpk / org.example.scorekeeperforgear / install_percent / 100
06-19 04:03:07.099+0900 D/PKGMGR  ( 2385): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[100]
06-19 04:03:07.099+0900 D/ADD_VIEWER( 2385): add-viewer_pkgmgr.c: progress_cb(385) > [SECURE_LOG] [org.example.scorekeeperforgear] 100
06-19 04:03:07.099+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:07.099+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:07.099+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575 / coretpk / org.example.scorekeeperforgear / install_percent / 100
06-19 04:03:07.099+0900 D/PKGMGR  ( 2385): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[100]
06-19 04:03:07.099+0900 D/W_HOME  ( 2385): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.scorekeeperforgear key:install_percent val:100
06-19 04:03:07.099+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:07.099+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:07.099+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575 / coretpk / org.example.scorekeeperforgear / install_percent / 100
06-19 04:03:07.099+0900 D/PKGMGR  ( 2385): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[100]
06-19 04:03:07.099+0900 D/APPS    ( 2385): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [install_percent:100] for org.example.scorekeeperforgear
06-19 04:03:07.099+0900 D/APPS    ( 2385): pkgmgr.c: _install_percent(469) >  package(org.example.scorekeeperforgear) with 100
06-19 04:03:07.099+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:07.099+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:07.099+0900 D/PKGMGR  ( 2386): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575 / coretpk / org.example.scorekeeperforgear / install_percent / 100
06-19 04:03:07.099+0900 D/PKGMGR  ( 2386): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[install_percent] val[100]
06-19 04:03:07.099+0900 D/PKGMGR  ( 2386): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:07.099+0900 D/PKGMGR  ( 2386): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:07.099+0900 D/PKGMGR  ( 2538): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575 / coretpk / org.example.scorekeeperforgear / end / ok
06-19 04:03:07.099+0900 D/PKGMGR  ( 2538): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[end] val[ok]
06-19 04:03:07.099+0900 D/PKGMGR  ( 2538): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:07.099+0900 D/PKGMGR  ( 2538): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:07.109+0900 D/PKGMGR  ( 2425): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575 / coretpk / org.example.scorekeeperforgear / end / ok
06-19 04:03:07.109+0900 D/PKGMGR  ( 2425): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[end] val[ok]
06-19 04:03:07.109+0900 D/DATA_PROVIDER_MASTER( 2425): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.scorekeeperforgear] ok
06-19 04:03:07.109+0900 D/PKGMGR  ( 2425): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:07.109+0900 D/PKGMGR  ( 2425): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:07.109+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
06-19 04:03:07.109+0900 D/PKGMGR  ( 2324): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [install] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575 / coretpk / org.example.scorekeeperforgear / end / ok
06-19 04:03:07.109+0900 D/PKGMGR  ( 2324): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[end] val[ok]
06-19 04:03:07.109+0900 D/AUL_AMD ( 2324): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(538) > [SECURE_LOG] pkgid(org.example.scorekeeperforgear), key(end), value(ok)
06-19 04:03:07.109+0900 D/AUL_AMD ( 2324): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(564) > [SECURE_LOG] op(install), value(ok)
06-19 04:03:07.109+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.scorekeeperforgear, 7), result=[0]
06-19 04:03:07.109+0900 D/PKGMGR  ( 2386): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575 / coretpk / org.example.scorekeeperforgear / end / ok
06-19 04:03:07.109+0900 D/PKGMGR  ( 2386): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[end] val[ok]
06-19 04:03:07.109+0900 D/PKGMGR  ( 2386): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:07.109+0900 D/PKGMGR  ( 2386): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:07.109+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575 / coretpk / org.example.scorekeeperforgear / end / ok
06-19 04:03:07.109+0900 D/PKGMGR  ( 2385): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[end] val[ok]
06-19 04:03:07.109+0900 D/ADD_VIEWER( 2385): add-viewer_pkgmgr.c: end_cb(420) > [SECURE_LOG] [org.example.scorekeeperforgear] ok
06-19 04:03:07.109+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:07.109+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:07.109+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575 / coretpk / org.example.scorekeeperforgear / end / ok
06-19 04:03:07.109+0900 D/PKGMGR  ( 2385): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[end] val[ok]
06-19 04:03:07.109+0900 D/W_HOME  ( 2385): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.scorekeeperforgear key:end val:ok
06-19 04:03:07.109+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:07.109+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:07.109+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575 / coretpk / org.example.scorekeeperforgear / end / ok
06-19 04:03:07.109+0900 D/PKGMGR  ( 2385): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[end] val[ok]
06-19 04:03:07.109+0900 D/APPS    ( 2385): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [end:ok] for org.example.scorekeeperforgear
06-19 04:03:07.109+0900 D/APPS    ( 2385): pkgmgr.c: _end(651) >  Package(org.example.scorekeeperforgear) : key(update) - val(ok)
06-19 04:03:07.109+0900 D/AUL_AMD ( 2324): amd_appinfo.c: __app_info_insert_handler(185) > __app_info_insert_handler
06-19 04:03:07.109+0900 D/AUL_AMD ( 2324): amd_appinfo.c: __app_info_insert_handler(388) > [SECURE_LOG] appinfo file:org.example.scorekeeperforgear, comp:ui, type:rpm
06-19 04:03:07.109+0900 D/PKGMGR  ( 2324): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:07.109+0900 D/PKGMGR  ( 2324): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:07.109+0900 D/PKGMGR  ( 2265): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [install] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575 / coretpk / org.example.scorekeeperforgear / end / ok
06-19 04:03:07.109+0900 D/PKGMGR  ( 2265): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[end] val[ok]
06-19 04:03:07.109+0900 D/APPS    ( 2385): pkgmgr.c: _end_cb(614) > [SECURE_LOG]  status[update], appid[org.example.scorekeeperforgear]
06-19 04:03:07.109+0900 D/APPS    ( 2385): scroller.c: apps_scroller_get_item_by_appid(1427) > [SECURE_LOG]  Get [org.example.scorekeeperforgear]'s item object
06-19 04:03:07.109+0900 D/APPS    ( 2385): db.c: apps_db_remove_item(404) >  Remove the item[org.example.scorekeeperforgear]
06-19 04:03:07.109+0900 D/PKGMGR  ( 2424): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] /opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575 / coretpk / org.example.scorekeeperforgear / end / ok
06-19 04:03:07.109+0900 D/PKGMGR  ( 2424): pkgmgr.c: __status_callback(455) > [SECURE_LOG] __status_callback() req_id[/opt/usr/apps/tmp/org.example.scorekeeperforgear-1.0.0-x86.tpk_-1423116575] pkg_type[coretpk] pkgid[org.example.scorekeeperforgear]key[end] val[ok]
06-19 04:03:07.109+0900 D/PKGMGR  ( 2424): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:07.109+0900 D/PKGMGR  ( 2424): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:07.109+0900 E/PKGMGR_INFO( 2265): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(695) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-19 04:03:07.109+0900 D/PKGMGR  ( 2265): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:07.109+0900 D/PKGMGR  ( 2265): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:07.119+0900 D/rpm-installer( 2760): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
06-19 04:03:07.119+0900 D/rpm-installer( 2760): coretpk-installer.c: _coretpk_installer_prepare_package_install_with_debug(2974) > _ri_privilege_enable_permissions(privilege/appdebugging succeeded for debug_mode.
06-19 04:03:07.119+0900 D/rpm-installer( 2760): rpm-appcore-intf.c: main(225) > sync() start
06-19 04:03:07.119+0900 D/APPS    ( 2385): pkgmgr.c: _uninstall_app(536) > [SECURE_LOG]  appid[org.example.scorekeeperforgear], name[scorekeeperforgear]
06-19 04:03:07.119+0900 D/APPS    ( 2385): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.scorekeeperforgear]
06-19 04:03:07.119+0900 D/DATA_PROVIDER_MASTER( 2425): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [51]
06-19 04:03:07.119+0900 D/DATA_PROVIDER_MASTER( 2425): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
06-19 04:03:07.119+0900 D/DATA_PROVIDER_MASTER( 2425): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 108 bytes
06-19 04:03:07.119+0900 D/BADGE   ( 2425): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.scorekeeperforgear'], count[0]
06-19 04:03:07.119+0900 D/DATA_PROVIDER_MASTER( 2425): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
06-19 04:03:07.119+0900 E/DATA_PROVIDER_MASTER( 2425): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
06-19 04:03:07.119+0900 D/COM_CORE( 2385): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2425, fd: -1
06-19 04:03:07.119+0900 D/COM_CORE( 2385): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2425), fd: -1
06-19 04:03:07.119+0900 D/COM_CORE( 2385): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 68 (recv_fd: -1)
06-19 04:03:07.119+0900 D/APPS    ( 2385): item_badge.c: item_badge_remove(305) > [SECURE_LOG]  pkgid: [org.example.scorekeeperforgear]
06-19 04:03:07.119+0900 D/COM_CORE( 2425): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
06-19 04:03:07.119+0900 D/DATA_PROVIDER_MASTER( 2425): service_common.c: tcb_create(482) > [SECURE_LOG] Create a new service thread [54]
06-19 04:03:07.119+0900 D/DATA_PROVIDER_MASTER( 2425): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb794d850 is terminated (NIL packet)
06-19 04:03:07.119+0900 D/DATA_PROVIDER_MASTER( 2425): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
06-19 04:03:07.119+0900 D/DATA_PROVIDER_MASTER( 2425): badge_service.c: service_thread_main(499) > [SECURE_LOG] Command: [delete_badge], Packet type[0]
06-19 04:03:07.119+0900 D/DATA_PROVIDER_MASTER( 2425): service_common.c: client_packet_pump_main(353) > [SECURE_LOG] Packet received: 108 bytes
06-19 04:03:07.119+0900 D/BADGE   ( 2425): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.scorekeeperforgear'], count[0]
06-19 04:03:07.119+0900 D/DATA_PROVIDER_MASTER( 2425): service_common.c: service_common_unicast_packet(1134) > [SECURE_LOG] Unicast packet
06-19 04:03:07.119+0900 E/DATA_PROVIDER_MASTER( 2425): badge_service.c: _handler_delete_badge(202) > [SECURE_LOG] Failed to delete a badge:-17956860
06-19 04:03:07.119+0900 D/COM_CORE( 2385): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2425, fd: -1
06-19 04:03:07.119+0900 D/COM_CORE( 2385): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2425), fd: -1
06-19 04:03:07.119+0900 D/COM_CORE( 2385): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 68 (recv_fd: -1)
06-19 04:03:07.119+0900 D/rpm-installer( 2760): rpm-appcore-intf.c: main(227) > sync() end
06-19 04:03:07.119+0900 D/rpm-installer( 2760): rpm-appcore-intf.c: main(246) > ------------------------------------------------
06-19 04:03:07.129+0900 D/COM_CORE( 2425): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
06-19 04:03:07.129+0900 D/DATA_PROVIDER_MASTER( 2425): badge_service.c: service_thread_main(490) > [SECURE_LOG] TCB: 0xb794d718 is terminated (NIL packet)
06-19 04:03:07.129+0900 D/rpm-installer( 2760): rpm-appcore-intf.c: main(247) >  [END] rpm-installer: result=[0]
06-19 04:03:07.129+0900 D/DATA_PROVIDER_MASTER( 2425): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
06-19 04:03:07.129+0900 D/rpm-installer( 2760): rpm-appcore-intf.c: main(248) > ------------------------------------------------
06-19 04:03:07.129+0900 D/APPS    ( 2385): pkgmgr.c: _install_app(496) > [SECURE_LOG]  appid[org.example.scorekeeperforgear], name[scorekeeperforgear]
06-19 04:03:07.129+0900 D/PKGMGR_SERVER( 2753): pkgmgr-server.c: sighandler(326) > child exit [2760]
06-19 04:03:07.129+0900 D/PKGMGR_SERVER( 2753): pkgmgr-server.c: sighandler(341) > child NORMAL exit [2760]
06-19 04:03:07.129+0900 D/APPS    ( 2385): item.c: item_create(819) >  Icon size after ea_effect (124:127)
06-19 04:03:07.129+0900 D/BADGE   ( 2385): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.scorekeeperforgear'], count[0]
06-19 04:03:07.129+0900 D/APPS    ( 2385): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.tizen.clocksetting]'s ordering : 0
06-19 04:03:07.129+0900 D/APPS    ( 2385): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.sensors2]'s ordering : 1
06-19 04:03:07.129+0900 D/APPS    ( 2385): scroller.c: apps_scroller_write_list(1344) > [SECURE_LOG]  [org.example.scorekeeperforgear]'s ordering : 2
06-19 04:03:07.129+0900 D/APPS    ( 2385): db.c: apps_db_update_item(374) >  Update the item[org.tizen.clocksetting:0]
06-19 04:03:07.129+0900 D/APPS    ( 2385): db.c: apps_db_update_item(374) >  Update the item[org.example.sensors2:1]
06-19 04:03:07.129+0900 D/APPS    ( 2385): db.c: apps_db_insert_item(345) >  Insert the item[org.example.scorekeeperforgear:2]
06-19 04:03:07.139+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
06-19 04:03:07.139+0900 D/PKGMGR  ( 2385): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
06-19 04:03:08.999+0900 D/PKGMGR_SERVER( 2753): pkgmgr-server.c: exit_server(724) > exit_server Start
06-19 04:03:08.999+0900 D/PKGMGR_SERVER( 2753): pkgmgr-server.c: main(1516) > Quit main loop.
06-19 04:03:08.999+0900 D/PKGMGR_SERVER( 2753): pkgmgr-server.c: main(1524) > package manager server terminated.
06-19 04:03:09.309+0900 D/AUL_AMD ( 2324): amd_request.c: __request_handler(506) > __request_handler: 0
06-19 04:03:09.309+0900 D/AUL_AMD ( 2324): amd_request.c: __request_handler(549) > launch a single-instance appid: org.example.scorekeeperforgear
06-19 04:03:09.309+0900 D/AUL     ( 2324): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 2817, pid = 2819
06-19 04:03:09.319+0900 D/AUL_AMD ( 2324): amd_launch.c: _start_app(1491) > [SECURE_LOG] caller : (null)
06-19 04:03:09.319+0900 D/AUL_AMD ( 2324): amd_launch.c: _start_app(1803) > process_pool: false
06-19 04:03:09.319+0900 D/AUL_AMD ( 2324): amd_launch.c: _start_app(1806) > h/w acceleration: SYS
06-19 04:03:09.319+0900 D/AUL_AMD ( 2324): amd_launch.c: _start_app(1808) > [SECURE_LOG] appid: org.example.scorekeeperforgear
06-19 04:03:09.319+0900 D/AUL_AMD ( 2324): amd_launch.c: __set_appinfo_for_launchpad(1978) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-19 04:03:09.319+0900 D/AUL     ( 2324): app_sock.c: __app_send_raw(270) > pid(-1) : cmd(0)
06-19 04:03:09.319+0900 D/AUL_PAD ( 2343): launchpad.c: __launchpad_main_loop(644) > [SECURE_LOG] pkg name : org.example.scorekeeperforgear
06-19 04:03:09.319+0900 D/AUL_PAD ( 2343): launchpad.c: __modify_bundle(381) > parsing app_path: No arguments
06-19 04:03:09.319+0900 D/AUL_PAD ( 2343): launchpad.c: __launchpad_main_loop(704) > [SECURE_LOG] ==> real launch pid : 2820 /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
06-19 04:03:09.319+0900 D/AUL_PAD ( 2343): launchpad.c: __send_result_to_caller(556) > -- now wait to change cmdline --
06-19 04:03:09.319+0900 D/AUL_PAD ( 2820): launchpad.c: __launchpad_main_loop(671) > lock up test log(no error) : fork done
06-19 04:03:09.319+0900 D/AUL_PAD ( 2820): launchpad.c: __launchpad_main_loop(682) > lock up test log(no error) : prepare exec - first done
06-19 04:03:09.319+0900 D/AUL_PAD ( 2820): launchpad.c: __prepare_exec(137) > [SECURE_LOG] pkg_name : org.example.scorekeeperforgear / pkg_type : rpm / app_path : /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear 
06-19 04:03:09.319+0900 D/AUL_PAD ( 2820): launchpad.c: __launchpad_main_loop(697) > lock up test log(no error) : prepare exec - second done
06-19 04:03:09.319+0900 D/AUL_PAD ( 2820): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear##
06-19 04:03:09.319+0900 D/AUL_PAD ( 2820): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-19 04:03:09.319+0900 D/AUL_PAD ( 2820): launchpad.c: __real_launch(224) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-19 04:03:09.319+0900 D/LAUNCH  ( 2820): launchpad.c: __real_launch(230) > [SECURE_LOG] [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear:Platform:launchpad:done]
06-19 04:03:09.319+0900 I/efl-extension( 2820): efl_extension.c: eext_mod_init(39) > Init
06-19 04:03:09.329+0900 W/CRASH_MANAGER( 2437): worker.c: worker_job(1189) > 110282073636f149781258
