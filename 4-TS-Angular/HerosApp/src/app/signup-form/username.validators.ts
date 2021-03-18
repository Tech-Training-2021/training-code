import { AbstractControl, ValidationErrors } from "@angular/forms";

export class UsernameValidators {
   static cannotContainSpace(control:AbstractControl) : ValidationErrors | null{
       if((control.value as string).indexOf(' ')>=0){
        console.log("space is there");
        return {cannotContainSpace:true}
       }
       else
       {
         console.log("No space ");
       return null;
       }
   }
}