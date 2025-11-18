{\rtf1\ansi\ansicpg1252\cocoartf2822
\cocoatextscaling0\cocoaplatform0{\fonttbl\f0\fswiss\fcharset0 Helvetica;}
{\colortbl;\red255\green255\blue255;}
{\*\expandedcolortbl;;}
\margl1440\margr1440\vieww14080\viewh8400\viewkind0
\pard\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\pardirnatural\partightenfactor0

\f0\fs24 \cf0 using System.Collections;\
using System.Collections.Generic;\
using UnityEngine;\
\
public class ThirdPersonCam : MonoBehaviour\
\{\
	[Header(\'93References\'94)]\
	public Transform orientation;\
	public Transform player;\
\pard\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\pardirnatural\partightenfactor0
\cf0 	public Transform playerObj;\
	public Rigidbody rb; \
\
	public float rotationSpeed;\
\
	private void Start()\
	\{\
		Cursor.lockState = CursorLockMode.Locked;\
		Cursor.visible = false;\
	\}\
\
	private void Update()\
	\{\
		// rotate orientation\
		Vector3 viewDir = player.position - new Vector3(transform.position.x, player.position.y, transform.position.z);\
		orientation.forward = viewDir.normalized;\
\
		//rotate player object \
		float horizontalInput = Input.GetAxis(\'93Horizontal\'94);\
		float verticalInput = Input.GetAxis(\'93Vertical\'94);\
		Vector3 inputDir = orientation.forward * verticalInput + orientation.right * horizontalInput; \'91\
\
		if(inputDir != Vector3.zero)\
			playerObj.forward = Vector3.Slerp(playerObj.forward, inputDir.normalized, Time.deltaTime * rotationSpeed);\
		\
\pard\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\pardirnatural\partightenfactor0
\cf0 \} }