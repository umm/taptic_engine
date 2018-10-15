#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

#ifdef __cplusplus
extern "C" {
#endif

    void _Impact(int mode) {
        UIImpactFeedbackStyle style = UIImpactFeedbackStyleMedium;
        
        switch (mode) {
            case 1:
                style = UIImpactFeedbackStyleLight;
                break;
            case 2:
                style = UIImpactFeedbackStyleMedium;
                break;
            case 3:
                style = UIImpactFeedbackStyleHeavy;
                break;
        }
        
        UIImpactFeedbackGenerator *generator = [[UIImpactFeedbackGenerator alloc] initWithStyle: style];
        [generator prepare]; // Not required on instant run.
        [generator impactOccurred];
        generator = NULL;
    }
    
    void _Selection() {
        UISelectionFeedbackGenerator *generator = [UISelectionFeedbackGenerator new];
        [generator prepare];
        [generator selectionChanged];
        generator = NULL;
    }
    
    void _Notification(int mode) {
        UINotificationFeedbackType style = UINotificationFeedbackTypeSuccess;
        
        switch (mode) {
            case 1:
                style = UINotificationFeedbackTypeSuccess;
                break;
            case 2:
                style = UINotificationFeedbackTypeWarning;
                break;
            case 3:
                style = UINotificationFeedbackTypeError;
                break;
        }
        
        UINotificationFeedbackGenerator *generator = [UINotificationFeedbackGenerator new];
        
        [generator prepare];
        [generator notificationOccurred:style];
        generator = NULL;
    }

#ifdef __cplusplus
}
#endif
