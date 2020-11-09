import { Component, Input } from '@angular/core';
import { ActionSheetController } from '@ionic/angular';
import { PhotoService } from '../services/photo.service';

@Component({
  selector: 'app-tab2',
  templateUrl: 'tab2.page.html',
  styleUrls: ['tab2.page.scss']
})
export class Tab2Page {
  @Input() images : Array<string>;
  constructor(public photoService: PhotoService, public actionSheetController: ActionSheetController) {
    this.images= ['F:\Final Project\disease-analyser\src\assets\images\0e90fe4a-e8b6-4186-9429-a9fea180af9a___FREC_Scab 3391_new30degFlipLR.JPG']
   }

  ngOnInit() {
    this.photoService.loadSaved();
  }

  public async showActionSheet(photo, position) {
    const actionSheet = await this.actionSheetController.create({
      header: 'Photos',
      buttons: [{
        text: 'Detect',
        icon: 'search',
        handler: () => {
          this.detect();
        }
      }, {
        text: 'Delete',
        role: 'destructive',
        icon: 'trash',
        handler: () => {
          this.photoService.deletePicture(photo, position);
        }
      }, {
        text: 'Cancel',
        icon: 'close',
        role: 'cancel',
        handler: () => {
          // Nothing to do, action sheet is automatically closed
        }
      }]
    });
    await actionSheet.present();
  }

  public async detect(){
    const actionSheet = await this.actionSheetController.create({
      header: 'Photos',
      buttons: [{
        text: 'Detect',
        icon: 'search',
        handler: () => {
          this.detect();
        }
      }, {
        text: 'Cancel',
        icon: 'close',
        role: 'cancel',
        handler: () => {
          // Nothing to do, action sheet is automatically closed
        }
      }]
    });
    await actionSheet.present();
  }
}
