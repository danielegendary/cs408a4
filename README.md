# cs408a4

Hierarchical Kinematic Models

At first I wanted to create a model myself, but the skeletal area was not well controlled, 
![old object](https://user-images.githubusercontent.com/67968545/201505771-c923275d-1b58-408e-b681-c555fbdddc92.PNG)
so I used the model from the unity asset store.

Using Animation Rigging feature in Unity to create bones in normal model.
![Capture](https://user-images.githubusercontent.com/67968545/201505835-f1392294-b1a3-4dae-a0ac-820183cf9bc4.PNG)
![Capture2](https://user-images.githubusercontent.com/67968545/201505837-8c599c75-bbdf-4372-ba87-3bd41d518a1f.PNG)
Draw the tree corresponding to the model corresponding to the program:

![IMG_3313](https://user-images.githubusercontent.com/67968545/201506475-d7699a1c-26c1-4053-b571-0499dd920982.jpg)


Using animation window to creat 3 poses as required:

pose 0: figure standing straight with legs straight down and arms straight out;

pose 1: figure standing with upper right arm straight out and lower right arm turned straight up; right leg out in kicking motion;
![a](https://user-images.githubusercontent.com/67968545/201506066-9d7bada1-5d0f-48b4-8bd5-2cd052421fbf.PNG)
pose 2: figure standing with upper left arm straight out and lower left arm turned straight up; lower part of right leg back
![old object](https://user-images.githubusercontent.com/67968545/201506689-927a1ee4-57ed-4b6a-a9cd-843c750ed2e6.PNG)


And use script files to implement switching of actions with keyboard control.
First add a few keys number 1 2 3 to preset key:
![3](https://user-images.githubusercontent.com/67968545/201506127-cb76cef3-03a4-496d-8f10-ce648d382e61.PNG)
![2](https://user-images.githubusercontent.com/67968545/201506221-54617854-bfe5-4f54-9a83-53e510bcd0dc.PNG)

script file:

![4](https://user-images.githubusercontent.com/67968545/201506094-d88b975a-3ee1-4d44-898b-c727b07cc14e.PNG)

Demo:

https://user-images.githubusercontent.com/67968545/201506140-802ecb3c-86e8-4e7a-92d2-5999ae962a1a.mp4

Creative feature:

Add headaim(or limb aim) feature in animation rigging to the bone and let it track objects.
![b](https://user-images.githubusercontent.com/67968545/201506288-df3085ed-8376-4bb2-a546-4e61a366526f.PNG)


Demo:

https://user-images.githubusercontent.com/67968545/201506299-a2427d2b-22f2-4279-b53e-180b6d55aa90.mp4

Add script file to toggle this feature with SPACE key
![1](https://user-images.githubusercontent.com/67968545/201506355-b84d5162-b4aa-48b1-8838-4e6f55af8e3c.PNG)

Final work:

https://user-images.githubusercontent.com/67968545/201506309-ff783a88-1012-49bf-b925-091e56d10734.mp4

