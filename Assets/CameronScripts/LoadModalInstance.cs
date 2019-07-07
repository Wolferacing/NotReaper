﻿using System.Collections;
using NotReaper;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

//  This script will be updated in Part 2 of this 2 part series.
public class LoadModalInstance : MonoBehaviour {
    private Modal modalPanel;
    private UnityAction Action1;
    private UnityAction Action2;
    private UnityAction Action3;
    private UnityAction Action4;

    public Timeline timeline;


    void Awake() {
        modalPanel = Modal.Instance();

        Action1 = new UnityAction(Function1);
        Action2 = new UnityAction(Function2);
        Action3 = new UnityAction(Function3);
        Action4 = new UnityAction(Function4);
    }

    //  Send to the Modal Panel to set up the Buttons and Functions to call
    public void LoadPanelStart() {
        modalPanel.Choice("NotReaper", Function1, Function2, Function3, Function4, "Load Audica File", "Don't click this", "Or this one", "I think this closes it", true, true, true, true);
        //modalPanel.Choice("NotReaper", Function1)
    }


    //new file
    void Function1() {
        timeline.LoadAudicaFile();
        timeline.projectStarted = true;
    }

    //load
    void Function2() {
        //timeline.Load();
        //timeline.projectStarted = true;
    }

    //load previous
    void Function3() {
        //if (PlayerPrefs.HasKey("previousSave"))
        //    timeline.LoadPrevious();
        //else
        //   timeline.NewFile();

        //timeline.projectStarted = true;
    }

    //quit
    void Function4() {
        Application.Quit();
    }
}