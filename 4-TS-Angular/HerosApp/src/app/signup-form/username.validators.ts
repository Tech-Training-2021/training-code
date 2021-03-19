import { AbstractControl, ValidationErrors } from "@angular/forms";

export class UsernameValidators {
   static cannotContainSpace(control:AbstractControl) : ValidationErrors | null{
       if((control.value as string).indexOf(' ')>=0){
        return {cannotContainSpace:true}
       }
       else
       {
         console.log("No space ");
       return null;
       }
   }
   static shouldBeUnique(control:AbstractControl):Promise<ValidationErrors|null>{
        return new Promise((resolve,reject)=>{
            setTimeout(()=>{
                console.log('inside setTimeout');
                if(control.value==='pushpinder'|| control.value==='Jai'){
                    console.log('username is taken');
                    resolve ({shouldBeUnique:true});
               }
                else
                    resolve (null);
               },3000); 
        })
        
    
   }
}