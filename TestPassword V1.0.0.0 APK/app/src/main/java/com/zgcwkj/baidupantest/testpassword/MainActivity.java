package com.zgcwkj.baidupantest.testpassword;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.webkit.WebView;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Button btn = (Button) findViewById(R.id.btnGo);
        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                EditText textUrl = (EditText) findViewById(R.id.textUrl);
                //验证长度
                if (textUrl.length() >= 8) {
                    String info = textUrl.getText().toString().replace(" ", "").replace("https", "").replace("http", "").replace("://pan.baidu.com/", "").replace("share/init?surl=", "").replace("s/1", "");
                    String url = "https://www.ypsuperkey.com/api/items/BDY-";
                    String uend = "?access_key=4fxNbkKKJX2pAm3b8AEu2zT5d2MbqGbD&client_version=zg";
                    WebView webView = (WebView) findViewById(R.id.webview);//更改界面的WebView控件的地址
                    webView.loadUrl(url + info + uend);
                } else {
                    Toast.makeText(MainActivity.this, "请输入正确的地址", Toast.LENGTH_LONG).show();
                }
            }
        });
    }
}