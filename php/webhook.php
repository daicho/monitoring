<?php
$access_token = 'hCh0EQNBrEO6VVlPTtbU5J6IibnkQxe6cIBd8ax7hplmb1WA1IQZCjs7HhzRDxFwo4hclidrZdY9IFLmrrTgsfJcqsM3aPAMBdqyNIPHCGztWCJZJ/4n90B6wx5nMPIuEH+ieaiNJK50v3a+4ztlIAdB04t89/1O/w1cDnyilFU=';
$userid = 'U370e9c2081a4b305e756946b5f6313a5';

// APIから送信されてきたイベントオブジェクトを取得
$json_string = file_get_contents('php://input');

$post_data = [
  'to' => $userid,
  'messages' => [
    [
      'type' => 'text',
      'text' => $json_string
    ]
  ]
];

// curlを使用してメッセージを返信する
$ch = curl_init("https://api.line.me/v2/bot/message/push");
curl_setopt($ch, CURLOPT_POST, true);
curl_setopt($ch, CURLOPT_CUSTOMREQUEST, 'POST');
curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
curl_setopt($ch, CURLOPT_POSTFIELDS, json_encode($post_data));
curl_setopt($ch, CURLOPT_HTTPHEADER, array(
	'Content-Type:application/json',
    'Authorization:Bearer ' . $access_token
));
$result = curl_exec($ch);
curl_close($ch);
